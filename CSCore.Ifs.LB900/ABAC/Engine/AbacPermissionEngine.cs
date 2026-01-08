using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.V2;
using CSSY103.C82Application.Dto.ABAC.Engine;
using CSSY103.C82Application.Service.UnitOfWork.ABAC;
using System.Data;
using System.Text.Json;

namespace CSSY103.C82Application.Service.ABAC.Engine;

/// <summary>
/// Engine principal de avaliação ABAC
/// </summary>
public class AbacPermissionEngine
{
    private readonly IABAC_UnitOfWork _unitOfWork;

    public AbacPermissionEngine(IABAC_UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// Avalia se o usuário tem permissão para executar uma ação em um recurso
    /// </summary>
    public async Task<AbacPermissionResult> EvaluatePermissionAsync(AbacPermissionRequest request)
    {
        try
        {
            // 1. Validar entrada
            if (string.IsNullOrWhiteSpace(request.UserId))
                return AbacPermissionResult.Deny("UserId is required");

            if (string.IsNullOrWhiteSpace(request.ResourceId))
                return AbacPermissionResult.Deny("ResourceId is required");

            if (string.IsNullOrWhiteSpace(request.ActionName))
                return AbacPermissionResult.Deny("ActionName is required");

            // 2. Buscar recurso
            var resource = await GetResourceAsync(request.ResourceId, request.TenantId);
            if (resource == null)
                return AbacPermissionResult.Deny($"Resource '{request.ResourceId}' not found");

            // 3. Buscar ação do recurso
            var action = await GetResourceActionAsync(resource.Id, request.ActionName);
            if (action == null)
                return AbacPermissionResult.Deny($"Action '{request.ActionName}' not found");

            // 4. Buscar políticas ativas
            var policies = await GetActivePoliciesAsync(request.TenantId);
            if (!policies.Any())
                return AbacPermissionResult.Deny("No active policies found");

            // 5. Buscar atributos do usuário
            var userAttributes = await GetUserAttributesAsync(request.UserId, request.TenantId);

            // 6. Avaliar políticas por prioridade (maior prioridade primeiro)
            foreach (var policy in policies.OrderByDescending(p => p.Priority ?? 0))
            {
                var rules = await GetPolicyRulesAsync(policy.Id);

                foreach (var rule in rules.OrderByDescending(r => r.Priority ?? 0))
                {
                    // Verificar se a regra se aplica a este recurso
                    if (!RuleAppliesToResource(rule, resource.Id, resource.Name))
                        continue;

                    // Verificar se a regra se aplica a esta ação
                    if (!RuleAppliesToAction(rule, request.ActionName))
                        continue;

                    // Verificar condições da regra
                    if (!string.IsNullOrWhiteSpace(rule.Conditions))
                    {
                        var conditionsMet = EvaluateConditions(rule.Conditions, userAttributes, request.Context);
                        if (!conditionsMet)
                            continue;
                    }

                    // Se chegou aqui, a regra se aplica!

                    // DENY tem precedência
                    if (rule.Effect?.Equals("Deny", StringComparison.OrdinalIgnoreCase) == true)
                    {
                        return AbacPermissionResult.Deny(
                            $"Denied by policy '{policy.Name}', rule '{rule.Rulename}'");
                    }

                    // ALLOW
                    if (rule.Effect?.Equals("Allow", StringComparison.OrdinalIgnoreCase) == true)
                    {
                        return AbacPermissionResult.Allow(
                            $"Allowed by policy '{policy.Name}', rule '{rule.Rulename}'",
                            policy.Id,
                            rule.Id
                        );
                    }
                }
            }

            // Nenhuma regra aplicável = Deny por padrão
            return AbacPermissionResult.Deny("No applicable rule found (default deny)");
        }
        catch (Exception ex)
        {
            return AbacPermissionResult.Deny($"Error: {ex.Message}");
        }
    }

    /// <summary>
    /// Obtém todas as permissões de um usuário para um recurso
    /// </summary>
    public async Task<AbacUserPermissions> GetUserResourcePermissionsAsync(
        string userId,
        string resourceId,
        int tenantId)
    {
        var result = new AbacUserPermissions
        {
            UserId = userId,
            ResourceId = resourceId
        };

        var resource = await GetResourceAsync(resourceId, tenantId);
        if (resource == null)
            return result;

        result = result with { ResourceName = resource.Name };

        var actions = await GetResourceActionsAsync(resourceId);

        foreach (var action in actions)
        {
            if (string.IsNullOrWhiteSpace(action.Actionname))
                continue;

            var permissionRequest = new AbacPermissionRequest
            {
                UserId = userId,
                ResourceId = resourceId,
                ActionName = action.Actionname,
                TenantId = tenantId
            };

            var permissionResult = await EvaluatePermissionAsync(permissionRequest);

            if (permissionResult.IsAllowed)
            {
                result.AllowedActions.Add(action.Actionname);
            }
            else
            {
                result.DeniedActions.Add(action.Actionname);
            }
        }

        return result;
    }

    #region Private Methods

    private async Task<ABAC_CSSPH_RESOURCE?> GetResourceAsync(string resourceId, int tenantId)
    {
        var filters = new List<FiltrosDinamicos>
        {
            new()
            {
                NomePropriedade = "Id",
                ValorPropriedade = resourceId,
                TipoDeIgualdade = TipoFiltroDinamico.Igual
            }
        };

        var resources = await _unitOfWork.GetABAC_CSSPH_RESOURCERepository.GetAllAsync(filters);
        var resource = resources.FirstOrDefault();

        // Se não encontrou por ID, tentar por nome
        if (resource == null)
        {
            filters[0] = new FiltrosDinamicos
            {
                NomePropriedade = "Name",
                ValorPropriedade = resourceId,
                TipoDeIgualdade = TipoFiltroDinamico.Igual
            };

            resources = await _unitOfWork.GetABAC_CSSPH_RESOURCERepository.GetAllAsync(filters);
            resource = resources.FirstOrDefault();
        }

        return resource;
    }

    private async Task<ABAC_CSSPH_RESOURCEACTIONS?> GetResourceActionAsync(string resourceId, string actionName)
    {
        var filters = new List<FiltrosDinamicos>
        {
            new()
            {
                NomePropriedade = "Resourceid",
                ValorPropriedade = resourceId,
                TipoDeIgualdade = TipoFiltroDinamico.Igual
            },
            new()
            {
                NomePropriedade = "Actionname",
                ValorPropriedade = actionName,
                TipoDeIgualdade = TipoFiltroDinamico.Igual
            }
        };

        var actions = await _unitOfWork.GetABAC_CSSPH_RESOURCEACTIONSRepository.GetAllAsync(filters);
        return actions.FirstOrDefault();
    }

    private async Task<IEnumerable<ABAC_CSSPH_RESOURCEACTIONS>> GetResourceActionsAsync(string resourceId)
    {
        var filters = new List<FiltrosDinamicos>
        {
            new()
            {
                NomePropriedade = "Resourceid",
                ValorPropriedade = resourceId,
                TipoDeIgualdade = TipoFiltroDinamico.Igual
            }
        };

        return await _unitOfWork.GetABAC_CSSPH_RESOURCEACTIONSRepository.GetAllAsync(filters);
    }

    private async Task<IEnumerable<OsusrE9aCsicpSy038>> GetActivePoliciesAsync(int tenantId)
    {
        var filters = new List<FiltrosDinamicos>
        {
            new()
            {
                NomePropriedade = "TenantId",
                ValorPropriedade = tenantId,
                TipoDeIgualdade = TipoFiltroDinamico.Igual
            },
            new()
            {
                NomePropriedade = "Isactive",
                ValorPropriedade = true,
                TipoDeIgualdade = TipoFiltroDinamico.Igual
            }
        };

        return await _unitOfWork.GetSY038Repository.GetAllAsync(filters);
    }

    private async Task<IEnumerable<OsusrE9aCsicpSy039>> GetPolicyRulesAsync(string policyId)
    {
        var filters = new List<FiltrosDinamicos>
        {
            new()
            {
                NomePropriedade = "Policyid",
                ValorPropriedade = policyId,
                TipoDeIgualdade = TipoFiltroDinamico.Igual
            }
        };

        return await _unitOfWork.GetSY039Repository.GetAllAsync(filters);
    }

    private async Task<Dictionary<string, string>> GetUserAttributesAsync(string userId, int tenantId)
    {
        var filters = new List<FiltrosDinamicos>
        {
            new()
            {
                NomePropriedade = "TenantId",
                ValorPropriedade = tenantId,
                TipoDeIgualdade = TipoFiltroDinamico.Igual
            },
            new()
            {
                NomePropriedade = "Sy032Usuarioid",
                ValorPropriedade = userId,
                TipoDeIgualdade = TipoFiltroDinamico.Igual
            }
        };

        var userAttrs = await _unitOfWork.GetSY032Repository.GetAllAsync(filters);

        return userAttrs
            .Where(a => !string.IsNullOrWhiteSpace(a.Attributename))
            .ToDictionary(
                a => a.Attributename!,
                a => a.Attributevalue ?? ""
            );
    }

    private bool RuleAppliesToResource(OsusrE9aCsicpSy039 rule, string resourceId, string? resourceName)
    {
        if (string.IsNullOrWhiteSpace(rule.Resources))
            return true; // Se não especificou recursos, aplica a todos

        try
        {
            var resources = JsonSerializer.Deserialize<List<string>>(rule.Resources) ?? new();

            // Verifica se contém o ID, nome ou wildcard
            return resources.Contains(resourceId) ||
                   resources.Contains(resourceName ?? "") ||
                   resources.Contains("*");
        }
        catch
        {
            return false;
        }
    }

    private bool RuleAppliesToAction(OsusrE9aCsicpSy039 rule, string actionName)
    {
        if (string.IsNullOrWhiteSpace(rule.Actions))
            return true; // Se não especificou ações, aplica a todas

        try
        {
            var actions = JsonSerializer.Deserialize<List<string>>(rule.Actions) ?? new();

            // Verifica se contém a ação ou wildcard
            return actions.Contains(actionName, StringComparer.OrdinalIgnoreCase) ||
                   actions.Contains("*");
        }
        catch
        {
            return false;
        }
    }

    private bool EvaluateConditions(
        string conditionsJson,
        Dictionary<string, string> userAttributes,
        Dictionary<string, object>? context)
    {
        try
        {
            var conditions = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(conditionsJson);
            if (conditions == null)
                return true;

            foreach (var condition in conditions)
            {
                var conditionMet = false;

                // Verificar nos atributos do usuário
                if (userAttributes.TryGetValue(condition.Key, out var userValue))
                {
                    conditionMet = CompareValues(userValue, condition.Value);
                }
                // Verificar no contexto adicional
                else if (context != null && context.TryGetValue(condition.Key, out var contextValue))
                {
                    conditionMet = CompareValues(contextValue?.ToString() ?? "", condition.Value);
                }

                if (!conditionMet)
                    return false;
            }

            return true;
        }
        catch
        {
            return false;
        }
    }

    private bool CompareValues(string actualValue, JsonElement expectedValue)
    {
        if (expectedValue.ValueKind == JsonValueKind.String)
        {
            return actualValue.Equals(expectedValue.GetString(), StringComparison.OrdinalIgnoreCase);
        }

        if (expectedValue.ValueKind == JsonValueKind.Array)
        {
            var values = expectedValue.EnumerateArray()
                .Select(e => e.GetString() ?? "")
                .ToList();
            return values.Contains(actualValue, StringComparer.OrdinalIgnoreCase);
        }

        return false;
    }

    #endregion
}