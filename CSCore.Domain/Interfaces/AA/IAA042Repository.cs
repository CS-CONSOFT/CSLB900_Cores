namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA042Repository : IBaseCrud<CSICP_Aa042>
    {
        Task<CSICP_Aa042?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Aa042>> GetListAsync(int tenant);
    }
}