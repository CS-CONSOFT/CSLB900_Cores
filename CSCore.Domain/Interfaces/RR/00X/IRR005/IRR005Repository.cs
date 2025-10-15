using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR005
{
    public interface IRR005Repository : IRepositorioBaseV2<OsusrTo3CsicpRr005>
    {
        Task<OsusrTo3CsicpRr005?> GetByIdAsync(int In_TenantID, long In_IDRR005);
        Task<(List<OsusrTo3CsicpRr005>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR005 prm);
    }
}