namespace CSCore.Domain.Interfaces.V2
{
    public interface IRepositorioBaseMudaAtivo<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        Task<TEntity> ChangeActiveAsync(string entityID, int tenant);
        Task<TEntity> ChangeActiveAsync(long entityID, int tenant);

    }
}
