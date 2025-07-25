namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB021aRepository : IBaseCrud<CSICP_Bb021a>
    {
        Task<CSICP_Bb021a?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb021a>> GetListAsync(int tenant, string? search);
    }
}
