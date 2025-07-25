using CSCore.Domain.CS_Models.CSICP_AA;

namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA030Repository : IBaseCrud<CSICP_AA030>
    {
        Task<CSICP_AA030?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_AA030>> GetListAsync(int tenant, string? search);
    }
}