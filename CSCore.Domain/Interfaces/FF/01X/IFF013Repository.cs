using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF._01X
{
    public interface IFF013Repository : IRepositorioBase<CSICP_FF013>
    {
        Task<(List<CSICP_FF013>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize, 
            string? in_ff012Id);
        Task<CSICP_FF013?> GetByIdAsync(int in_tenant, string in_ff013Id);
    }
}