using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._01X
{
    public interface IGG017Repository : IRepositorioBase<CSICP_GG017>
    {
        Task<(IEnumerable<CSICP_GG017>, int)> GetListAsync(int tenant, string? search, int pageSize, int page);
        Task<CSICP_GG017?> GetByIdAsync(long id, int tenant);
        Task<CSICP_GG017> CreateAsync(CSICP_GG017 entity);
    }
}
