using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR035
{
    public interface IRR035Repository : IRepositorioBaseV2<OsusrTo3CsicpRr035>
    {
        Task<OsusrTo3CsicpRr035?> GetByIdAsync(int In_TenantID, string In_IDRR035);
        Task<(List<OsusrTo3CsicpRr035>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR035 prm);
    }
}