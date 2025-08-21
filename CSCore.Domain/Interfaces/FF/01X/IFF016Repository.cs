using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF016;

namespace CSCore.Domain.Interfaces.FF._01X
{
    public interface IFF016Repository : IRepositorioBase<CSICP_FF016>
    {
        Task<(List<RepoDtoCSICP_FF016>, int)> GetListAsync(int in_tenant, string? in_descricaoCarta, int in_page, int in_pageSize);
        Task<RepoDtoCSICP_FF016?> GetByIdAsync(int in_tenant, string in_ff016Id);
    }
}