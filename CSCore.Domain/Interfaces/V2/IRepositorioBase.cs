namespace CSCore.Domain.Interfaces.V2
{
    public interface IRepositorioBase<TEntity>
        where TEntity : class
    {
        TEntity Create(TEntity entity);
        Task<TEntity?> UpdateAsync(string id, int tenant, TEntity entity);
        Task<TEntity?> UpdateAsync(long id, int tenant, TEntity entity);
        Task<TEntity?> RemoveAsync(string id, int tenant);
        Task<TEntity?> RemoveAsync(long id, int tenant);
        object GetEntityId(TEntity entity);
        Task CommitToDatabase();
    }
}
