namespace CSCore.Domain.Interfaces;

public interface IBaseCD<TEntity>
{
    Task<TEntity> CreateAsync(TEntity entity);
    Task<TEntity> RemoveAsync(TEntity entity);
}

