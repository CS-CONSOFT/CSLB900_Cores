namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB021Repository : IBaseCrud<CSICP_Bb021>
    {
        Task<CSICP_Bb021?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb021>> GetListAsync(int tenant, string? search, int? searchCode);
    }
}
