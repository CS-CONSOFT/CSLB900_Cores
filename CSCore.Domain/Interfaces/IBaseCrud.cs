namespace CSCore.Domain.Interfaces;

public interface IBaseCrud<TEntity>
{
    Task<TEntity> CreateAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<TEntity> RemoveAsync(TEntity entity);
}

