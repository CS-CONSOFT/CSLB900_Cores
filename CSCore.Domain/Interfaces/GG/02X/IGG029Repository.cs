using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._02X
{
    public interface IGG029Repository : IRepositorioBase<CSICP_GG029>
    {
        Task<(IEnumerable<CSICP_GG029>, int)> GetListAsync(int tenant, int pageSize, int page, string? search, string? codigo);
        Task<CSICP_GG029?> GetByIdAsync(string id, int tenant);
    }
}
