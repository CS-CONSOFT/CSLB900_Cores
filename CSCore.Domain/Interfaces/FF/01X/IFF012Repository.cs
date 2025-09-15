using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF._01X
{
    public interface IFF012Repository : IRepositorioBase<CSICP_FF012>
    {
        Task<(List<CSICP_FF012>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize, 
            string? in_estabId, int? in_codigoGrupo);
        Task<CSICP_FF012?> GetByIdAsync(int in_tenant, string in_ff012Id);
    }
}