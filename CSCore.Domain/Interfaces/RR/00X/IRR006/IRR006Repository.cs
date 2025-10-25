using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR006
{
    public interface IRR006Repository : IRepositorioBaseV2<OsusrTo3CsicpRr006>
    {
        Task<OsusrTo3CsicpRr006?> GetByIdAsync(int In_TenantID, long In_IDRR006);
        Task<(List<OsusrTo3CsicpRr006>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR006 prm);
    }
}