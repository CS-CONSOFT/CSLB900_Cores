using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR007
{
    public interface IRR007Repository : IRepositorioBaseV2<OsusrTo3CsicpRr007>
    {
        Task<OsusrTo3CsicpRr007?> GetByIdAsync(int In_TenantID, long In_IDRR007);
        Task<(List<OsusrTo3CsicpRr007>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR007 prm);
    }
}