namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA013Repository : IBaseCrud<CSICP_Aa013>
    {
        Task<CSICP_Aa013?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Aa013>> GetListAsync(int tenant, string? search);
    }
}