using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR003
{
    public interface IRR003Repository : IRepositorioBaseV2<OsusrTo3CsicpRr003>
    {
        Task<OsusrTo3CsicpRr003?> GetByIdAsync(int In_TenantID, long In_IDRR003);
        Task<(List<OsusrTo3CsicpRr003>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR003 prm);
    }
}