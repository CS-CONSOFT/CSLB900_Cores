using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF._01X
{
    public interface IFF011Repository : IRepositorioBase<CSICP_FF011>
    {
        Task<(List<CSICP_FF011>, int)> GetListAsync(int in_tenantID, int in_pageNumber, int in_pageSize,
            string? in_tipoCobrancaID, string? in_categoriaID);
        Task<CSICP_FF011?> GetByIdAsync(int in_tenantID, string in_ff011ID);
    }
}
