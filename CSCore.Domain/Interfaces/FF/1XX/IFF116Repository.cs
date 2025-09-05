using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF116Repository : IRepositorioBase<CSICP_FF116>
    {
        Task<(List<RepoDtoCSICP_FF116>, int)> GetListAsync(
            int in_tenant, string in_ff102Id, int in_pageNumber, int in_pageSize);
    }
}