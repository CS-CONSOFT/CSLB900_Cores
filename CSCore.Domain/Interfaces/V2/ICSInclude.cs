namespace CSCore.Domain.Interfaces.V2
{
    public interface ICSInclude<TEntity>
    {
        IQueryable<TEntity> ApplyIncludes(IQueryable<TEntity> query);
    }
}
