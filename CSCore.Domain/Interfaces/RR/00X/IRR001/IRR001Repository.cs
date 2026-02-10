using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X
{
    public interface IRR001Repository : IGetListBase<OsusrTo3CsicpRr001, PrmFiltrosRR001>, IRepositorioBaseV2<OsusrTo3CsicpRr001>
    {
        Task<OsusrTo3CsicpRr001?> GetByIdAsync(int In_TenantID, string In_IDRR001);
        Task<(List<OsusrTo3CsicpRr001>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR001 prm);
        Task<(List<OsusrTo3CsicpRr001>, int)> GetListAnimaisSemLoteAsync(int In_TenantID, int pageNumber, int pageSize);
        Task<bool> ExisteAnimalRR001Async(int In_TenantID, string In_Rr001Id);
    }
}
