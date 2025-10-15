using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR004
{
    public interface IRR004Repository : IRepositorioBaseV2<OsusrTo3CsicpRr004>
    {
        Task<OsusrTo3CsicpRr004?> GetByIdAsync(int In_TenantID, long In_IDRR004);
        Task<(List<OsusrTo3CsicpRr004>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR004 prm);
    }
}