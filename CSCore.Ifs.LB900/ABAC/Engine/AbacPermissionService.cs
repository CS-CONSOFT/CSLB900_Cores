using CSSY103.C82Application.Dto.ABAC.Engine;
using CSSY103.C82Application.Service.ABAC.Engine;

namespace CSSY103.C82Application.Service.ABAC;

/// <summary>
/// Serviço de permissões ABAC com cache integrado
/// </summary>
public class AbacPermissionService
{
    private readonly AbacPermissionEngine _engine;
    private readonly AbacPermissionCacheService _cache;

    public AbacPermissionService(
        AbacPermissionEngine engine,
        AbacPermissionCacheService cache)
    {
        _engine = engine;
        _cache = cache;
    }

    /// <summary>
    /// Verifica permissão com cache
    /// </summary>
    public async Task<bool> CheckPermissionAsync(
        string userId,
        string resourceId,
        string actionName,
        int tenantId,
        Dictionary<string, object>? context = null)
    {
        // 1. Tentar buscar no cache (RÁPIDO)
        if (_cache.TryGetPermission(userId, resourceId, actionName, tenantId, out var cachedResult))
        {
            return cachedResult;
        }

        // 2. Se não estiver no cache, avaliar (VAI AO BANCO)
        var request = new AbacPermissionRequest
        {
            UserId = userId,
            ResourceId = resourceId,
            ActionName = actionName,
            TenantId = tenantId,
            Context = context
        };

        var result = await _engine.EvaluatePermissionAsync(request);

        // 3. Armazenar no cache
        _cache.SetPermission(userId, resourceId, actionName, tenantId, result.IsAllowed);

        return result.IsAllowed;
    }

    /// <summary>
    /// Obtém todas as permissões de um usuário (com cache)
    /// </summary>
    public async Task<AbacUserPermissions> GetUserPermissionsAsync(
        string userId,
        string resourceId,
        int tenantId)
    {
        return await _engine.GetUserResourcePermissionsAsync(userId, resourceId, tenantId);
    }

    /// <summary>
    /// Invalida cache quando houver mudanças
    /// </summary>
    public void InvalidateCache(string userId, int tenantId)
    {
        _cache.InvalidateUserCache(userId, tenantId);
    }
}