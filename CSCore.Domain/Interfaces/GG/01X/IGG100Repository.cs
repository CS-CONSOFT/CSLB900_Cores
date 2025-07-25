using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._01X
{
    public interface IGG100Repository : IRepositorioBase<CSICP_GG100>
    {
        Task<(IEnumerable<CSICP_GG100>, int)> GetListAsync(int tenant, int pageSize, int page);
        Task<CSICP_GG100?> GetByIdAsync(long id, int tenant);
    }
}
