using CSCore.Domain.CS_Models.CSICP_AA;

namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA012Repository : IBaseCrud<CSICP_Aa012>
    {
        Task<CSICP_Aa012?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Aa012>> GetListAsync(int tenant, string? search, int? searchCode);
    }
}
