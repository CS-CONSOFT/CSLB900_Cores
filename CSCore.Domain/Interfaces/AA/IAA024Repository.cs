using CSCore.Domain.CS_Models.CSICP_AA;

namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA024Repository : IBaseCrud<CSICP_Aa024>
    {
        Task<CSICP_Aa024?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Aa024>> GetListAsync(int tenant, string? search, int? searchCode);
    }
}
