using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._00X.GG008
{
    public interface IGG008iRepository : IRepositorioBase<CSICP_GG008i>
    {
        Task<CSICP_GG008i> GetByIdAsync(string gg008i_id, string? kardexGG008_ID, int tenant);
        Task<(IEnumerable<CSICP_GG008i>, int)> GetListAsync(
            int in_tenant, string? in_kardexGG008_ID, string? in_ncmID, string in_filialID, int pageSize, int page);
    }
}
