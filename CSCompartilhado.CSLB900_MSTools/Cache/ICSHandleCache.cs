namespace CSLB900.MSTools.Cache
{
    public interface ICSHandleCache
    {
        /// <summary>
        /// Armazena dados no cache de memória com configurações de expiração deslizante e absoluta.
        /// </summary>
        /// <typeparam name="T">Tipo de dados a serem armazenados no cache</typeparam>
        /// <param name="cacheKey">Chave única para identificar o item no cache</param>
        /// <param name="slidingTime">Tempo em segundos para expiração deslizante (renova quando acessado)</param>
        /// <param name="absoluteTime">Tempo em segundos para expiração absoluta (expira independente do acesso)</param>
        /// <param name="func">Função assíncrona que retorna os dados a serem armazenados no cache</param>
        /// <returns>Task que representa a operação assíncrona de cache com o resultado do tipo T</returns>
        Task<T?> ColocaNoCache<T>(
            string cacheKey,
            int slidingTime,
            int absoluteTime,
            Func<Task<T>> func);
    }
}
