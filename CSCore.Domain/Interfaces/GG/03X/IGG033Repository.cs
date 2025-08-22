using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._03X
{
    public interface IGG033Repository : IRepositorioBase<CSICP_GG033>
    {
        Task<(IEnumerable<CSICP_GG033>, int)> GetListAsync(
            int tenant,
            string? search,
            string? GG032_ID,
            int pageSize, int page);

        Task<CSICP_GG033?> GetByIdAsync(string id, int tenant);
    }
}
