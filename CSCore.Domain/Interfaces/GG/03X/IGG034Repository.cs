using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._03X
{
    public interface IGG034Repository : IRepositorioBase<CSICP_GG034>
    {
        Task<(IEnumerable<CSICP_GG034>, int)> GetListAsync(int tenant, int pageSize, int page);
        Task<CSICP_GG034?> GetByIdAsync(int tenant, string id);
    }
}
