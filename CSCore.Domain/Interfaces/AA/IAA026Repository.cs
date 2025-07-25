namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA026Repository : IBaseCrud<CSICP_Aa026>
    {
        Task<CSICP_Aa026?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Aa026>> GetListAsync(int tenant, string? search, int? searchCode);
    }
}
