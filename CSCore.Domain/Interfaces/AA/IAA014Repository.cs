namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA014Repository : IBaseCrud<CSICP_Aa014>
    {
        Task<CSICP_Aa014?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Aa014>> GetListAsync(int tenant);
    }
}