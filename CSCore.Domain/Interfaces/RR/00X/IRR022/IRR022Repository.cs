using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR022
{
    public interface IRR022Repository : IRepositorioBaseV2<OsusrTo3CsicpRr022>
    {
        Task<OsusrTo3CsicpRr022?> GetByIdAsync(int In_TenantID, string In_IDRR022);
        Task<(List<OsusrTo3CsicpRr022>, int)> GetListRR022ByRR021IdAsync(int In_TenantID, string In_RR021ID, PrmFiltrosRR022 prm);
    }
}