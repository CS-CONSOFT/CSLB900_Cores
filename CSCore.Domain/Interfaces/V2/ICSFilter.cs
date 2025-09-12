namespace CSCore.Domain.Interfaces.V2
{
    public interface ICSFilter<T>
    {
        IQueryable<T> Apply(IQueryable<T> query);
    }
}
