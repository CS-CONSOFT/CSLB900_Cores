using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF103Repository : IRepositorioBase<CSICP_FF103>
    {
        Task<(List<CSICP_FF103>, int)> GetListAsync(int in_tenant, string? inff102ID, int in_pageNumber, int in_pageSize);

        Task<CSICP_FF103> GetByIdAsync(int in_tenant, string in_ff103Id);
    }
}
