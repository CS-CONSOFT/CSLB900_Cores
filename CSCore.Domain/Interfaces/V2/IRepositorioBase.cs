namespace CSCore.Domain.Interfaces.V2
{
    [Obsolete("Use IRepositorioBaseV2 instead")]
    public interface IRepositorioBase<TEntity>
        where TEntity : class
    {
        TEntity Create(TEntity entity);
        Task<int> BulkCreateAsync(List<TEntity> entities);
        Task<int> BulkCreateAsync(IEnumerable<TEntity> entities);
        Task<TEntity?> UpdateAsync(string id, int tenant, TEntity entity);
        Task<TEntity?> UpdateAsync(long id, int tenant, TEntity entity);
        Task<TEntity?> RemoveAsync(string id, int tenant);
        Task<TEntity?> RemoveAsync(long id, int tenant);
        object GetEntityId(TEntity entity);
        Task CommitToDatabase();

        Task SalvarLogAsync(
    int tenantId,
    string nomeUsuario,
    string severidade,
    string mensagem,
    string? jsonHeader = null,
    string? jsonQuery = null,
    string? jsonBody = null,
    bool isExibiu = false);
    }

    public interface IRepositorioBaseV2<TEntity>
    where TEntity : class
    {
        TEntity Create(TEntity entity);
        int CreateRange(List<TEntity> entity);
        Task<int> BulkCreateAsync(List<TEntity> entities);
        Task<int> BulkCreateAsync(IEnumerable<TEntity> entities);
        Task<TEntity?> UpdateAsync(string id, int tenant, TEntity entity);
        Task<TEntity?> UpdateAsync(long id, int tenant, TEntity entity);
        Task<TEntity?> RemoveAsync(string id, int tenant);
        Task<TEntity?> RemoveAsync(long id, int tenant);
        object GetEntityId(TEntity entity);

        Task SalvarLogAsync(
    int tenantId,
    string nomeUsuario,
    string severidade,
    string mensagem,
    string? jsonHeader = null,
    string? jsonQuery = null,
    string? jsonBody = null,
    bool isExibiu = false);
    }
}
