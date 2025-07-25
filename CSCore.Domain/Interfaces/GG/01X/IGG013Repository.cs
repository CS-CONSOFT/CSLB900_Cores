using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._01X
{
    public interface IGG013Repository : IRepositorioBase<CSICP_GG013>
    {
        Task<(IEnumerable<CSICP_GG013>, int)> GetListAsync
            (int tenant, string Produto_ID, int pageSize, int page, string? search);
        Task<CSICP_GG013?> GetByIdAsync(string gg013_gg08_id, int tenant);
    }
}
