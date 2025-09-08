using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF014;

namespace CSCore.Domain.Interfaces.FF._01X
{
    public interface IFF014Repository : IRepositorioBase<CSICP_FF014>
    {
        Task<RepoDtoCSICP_FF014?> GetByIdAsync(int in_tenantID, string in_ff014ID);
        Task<(List<RepoDtoCSICP_FF014>, int)> GetListAsync(int in_tenantID, int in_pageNumber, int in_pageSize, 
            string? in_filialID, string? in_descricao, string? in_comissaoID);
    }
}