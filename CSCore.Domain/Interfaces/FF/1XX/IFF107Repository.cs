using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF107;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF107Repository : IRepositorioBase<CSICP_FF107>
    {
        Task<(List<RepoDtoCSICP_FF107>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize,
            string in_ff102Id);
    }
}