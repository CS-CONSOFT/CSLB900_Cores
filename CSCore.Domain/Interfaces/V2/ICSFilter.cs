namespace CSCore.Domain.Interfaces.V2
{
    public interface ICSFilter<TEntity>
    {
        IQueryable<TEntity> Apply(IQueryable<TEntity> query);
    }
}
