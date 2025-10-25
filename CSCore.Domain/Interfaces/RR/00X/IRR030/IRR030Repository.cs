using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR030
{
    public interface IRR030Repository : IRepositorioBaseV2<OsusrTo3CsicpRr030>
    {
        Task<OsusrTo3CsicpRr030?> GetByIdAsync(int In_TenantID, string In_IDRR030);
        Task<(List<OsusrTo3CsicpRr030>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR030 prm);
    }
}