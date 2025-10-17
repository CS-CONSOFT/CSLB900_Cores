using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR008
{
    public interface IRR008Repository : IRepositorioBaseV2<OsusrTo3CsicpRr008>
    {
        Task<OsusrTo3CsicpRr008?> GetByIdAsync(int In_TenantID, long In_IDRR008);
        Task<(List<OsusrTo3CsicpRr008>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR008 prm);
    }
}