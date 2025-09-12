namespace CSCore.Domain.Interfaces.V2
{
    public interface ICSInclude<T>
    {
        IQueryable<T> ApplyIncludes(IQueryable<T> query);
    }
}
