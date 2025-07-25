namespace CSCore.Domain.Interfaces
{
    public interface ISateliteCD<TEntity> : IBaseCD<TEntity>
    {
        Task<TEntity?> GetEntityAsync(string id, int tenant);
    }
}
