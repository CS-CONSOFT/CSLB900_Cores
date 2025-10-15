using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR020
{
    public interface IRR020Repository : IRepositorioBaseV2<OsusrTo3CsicpRr020>
    {
        Task<OsusrTo3CsicpRr020?> GetByIdAsync(int In_TenantID, string In_IDRR020);
        Task<(List<OsusrTo3CsicpRr020>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR020 prm);
    }
}