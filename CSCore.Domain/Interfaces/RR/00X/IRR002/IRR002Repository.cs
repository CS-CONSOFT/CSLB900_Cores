using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR002
{
    public interface IRR002Repository : IRepositorioBaseV2<OsusrTo3CsicpRr002>
    {
        Task<OsusrTo3CsicpRr002?> GetByIdAsync(int In_TenantID, string In_IDRR002);
        Task<(List<OsusrTo3CsicpRr002>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR002 prm);
    }
}