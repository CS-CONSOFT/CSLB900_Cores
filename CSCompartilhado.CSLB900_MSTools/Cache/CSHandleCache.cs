using Microsoft.Extensions.Caching.Memory;
using Serilog;

namespace CSLB900.MSTools.Cache
{
    public class CSHandleCache : ICSHandleCache
    {
        private readonly IMemoryCache memoryCache;

        public CSHandleCache(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }


        public async Task<T?> ColocaNoCache<T>(
            string cacheKey,
            int slidingTime,
            int absoluteTime,
            Func<Task<T>> func)
        {
            return await memoryCache.GetOrCreateAsync(cacheKey, async entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromSeconds(slidingTime);
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(absoluteTime);
                entry.Priority = CacheItemPriority.Normal;
                Log.Information("CSCache: Não estava no cache | Criando novo item | Chave: {CacheKey} | Tipo: {Type}", cacheKey, typeof(T).Name);
                //Consulta só executa se não estiver em cache
                return await func();
            });
        }
    }
}
