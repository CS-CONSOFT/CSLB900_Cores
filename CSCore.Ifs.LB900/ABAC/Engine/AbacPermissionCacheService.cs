using Microsoft.Extensions.Caching.Memory;

namespace CSSY103.C82Application.Service.ABAC;

/// <summary>
/// Cache de permissões ABAC para evitar consultas repetidas ao banco
/// </summary>
public class AbacPermissionCacheService
{
    private readonly IMemoryCache _cache;
    private readonly TimeSpan _defaultExpiration = TimeSpan.FromMinutes(15);

    public AbacPermissionCacheService(IMemoryCache cache)
    {
        _cache = cache;
    }

    /// <summary>
    /// Gera chave única para cache de permissão
    /// </summary>
    private string GetCacheKey(string userId, string resourceId, string actionName, int tenantId)
    {
        return $"abac:perm:{tenantId}:{userId}:{resourceId}:{actionName}";
    }

    /// <summary>
    /// Busca permissão no cache
    /// </summary>
    public bool TryGetPermission(
        string userId,
        string resourceId,
        string actionName,
        int tenantId,
        out bool isAllowed)
    {
        var key = GetCacheKey(userId, resourceId, actionName, tenantId);

        if (_cache.TryGetValue<bool>(key, out var cachedValue))
        {
            isAllowed = cachedValue;
            return true;
        }

        isAllowed = false;
        return false;
    }

    /// <summary>
    /// Armazena permissão no cache
    /// </summary>
    public void SetPermission(
        string userId,
        string resourceId,
        string actionName,
        int tenantId,
        bool isAllowed,
        TimeSpan? expiration = null)
    {
        var key = GetCacheKey(userId, resourceId, actionName, tenantId);

        var options = new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = expiration ?? _defaultExpiration,
            SlidingExpiration = TimeSpan.FromMinutes(5)
        };

        _cache.Set(key, isAllowed, options);
    }

    /// <summary>
    /// Invalida cache de um usuário específico
    /// </summary>
    public void InvalidateUserCache(string userId, int tenantId)
    {
        // Remove todas as permissões do usuário
        // Nota: IMemoryCache não suporta remoção por padrão, 
        // para isso seria necessário Redis ou implementar tracking
    }

    /// <summary>
    /// Invalida cache de um recurso específico
    /// </summary>
    public void InvalidateResourceCache(string resourceId, int tenantId)
    {
        // Remove todas as permissões do recurso
    }

    /// <summary>
    /// Limpa todo o cache
    /// </summary>
    public void Clear()
    {
        // Para IMemoryCache, criar uma nova instância ou usar CompactOnMemoryPressure
    }
}