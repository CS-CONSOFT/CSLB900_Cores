using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.LB900.ABAC.Engine.ClassesAuxiliares;
using CSCore.Ifs.LB900.ABAC.Engine.Conditions;
using CSCore.Ifs.LB900.ABAC.Engine.dto;
using CSLB900.MSTools.Util;
using CSSY103.C82Application.Dto.ABAC.Engine;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace CSCore.Ifs.LB900.ABAC.Engine;

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
            var (_reqIsValid, _reqMessage) = request.IsValidRequest();
            if (!_reqIsValid) 
                return AbacPermissionResult.Deny(_reqMessage);

            // 2. Buscar recurso
            var resource = await GetResourceAsync(request.ResourceId, request.TenantId);
            if (resource == null)
                return AbacPermissionResult.Deny($"Resource '{request.ResourceId}' not found");

            // 2.1 Buscar atributos do recurso
            var resourceAttributes = await GetResourceAttributesAsync(resource.Id);

            // 3. Buscar ação do recurso
            var action = await GetResourceActionAsync(resource.Id, request.ActionName);

            // 4. Buscar políticas ativas
            var policies = await GetActivePoliciesAsync(request.TenantId);
            // se nao tiver policde, oq fazer?

            // 5. Buscar atributos do usuário
            var userAttributes = await GetUserAttributesAsync(request.UserId, request.TenantId);

            // busca atributos de contexto
            var contextAttributes = this._unitOfWork.HandleContextAttributes.GetListaContextAttributes();

            // 6. Avaliar políticas por prioridade (maior prioridade primeiro)
            if (!policies.Any()) return AbacPermissionResult.Deny("Nenhuma politica encontrada!");
            foreach (var policy in policies.OrderByDescending(p => p.Priority ?? 0))
            {
                var rules = policy.NavAbacRules ?? [];
                if (rules.Count == 0) continue;

                foreach (var rule in rules.OrderByDescending(r => r.Priority ?? 0))
                {
                    if(!rule.ARegraEhAplicadaAEsseRecurso(resource.Id, resource.Name))
                        continue;

                    if (!rule.ARegraEhAplicadaAEssaAcao(request.ActionName))
                        continue;

                    // Verificar condições da regra
                    RuleEffect ruleEffect = rule.ValidarCondicao(AbacConditionEvaluator.Instance, userAttributes, resourceAttributes, contextAttributes);
                    if (ruleEffect == RuleEffect.Deny)
                        continue;

                    // Se chegou aqui, a regra se aplica!

                    // DENY tem precedência
                    if (rule.IsDeny())
                    {
                        return AbacPermissionResult.Deny(
                            $"Negado pela politica'{policy.Name}', regra '{rule.Rulename}'");
                    }

                    // ALLOW
                    if (rule.IsAllow())
                    {
                        return AbacPermissionResult.Allow(
                            $"Permitido pela politica '{policy.Name}', regra '{rule.Rulename}'",
                            policy.Id,
                            rule.Id
                        );
                    }
                }
            }

            // Nenhuma regra aplicável = Deny por padrão
            return AbacPermissionResult.Deny("Nenhuma regra aplicável");
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

    private async Task<IEnumerable<ABAC_CSSPH_RESOURCEATRIB>> GetResourceAttributesAsync(string resourceId)
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
        var resourceAttrs = await _unitOfWork.GetABAC_CSSPH_RESOURCEATRIB_Repository.GetAllAsync(filters);
        return resourceAttrs;
    }


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

        //se nao achar, pegar pelo module

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

        var dicUserAtributos = userAttrs
            .Where(a => !string.IsNullOrWhiteSpace(a.Attributename))
            .ToDictionary(
                a => a.Attributename!,
                a => a.Attributevalue ?? ""
            );

        IEnumerable<string> listaNomesDosAtributosDaSY031APartirDaSY030 = await _unitOfWork.GetSY030Repository.GetAtributosDeUsuarioAPartirDaSY030(tenantId, userId);
        if (dicUserAtributos.ContainsKey(Constantes.USER_GROUP))
            dicUserAtributos[Constantes.USER_GROUP] += "," + string.Join(",", listaNomesDosAtributosDaSY031APartirDaSY030);
        else
            dicUserAtributos.Add(Constantes.USER_GROUP, string.Join(",", listaNomesDosAtributosDaSY031APartirDaSY030));

        return dicUserAtributos;

    }
    #endregion
}