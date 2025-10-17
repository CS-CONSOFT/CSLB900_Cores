using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR031
{
    public interface IRR031Repository : IRepositorioBaseV2<OsusrTo3CsicpRr031>
    {
        Task<OsusrTo3CsicpRr031?> GetByIdAsync(int In_TenantID, string In_IDRR031);
        Task<(List<OsusrTo3CsicpRr031>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR031 prm);
    }
}