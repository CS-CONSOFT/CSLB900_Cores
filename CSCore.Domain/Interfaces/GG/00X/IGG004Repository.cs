using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._00X
{
    public interface IGG004Repository : IRepositorioBaseMudaAtivo<CSICP_GG004>
    {
        Task<(IEnumerable<CSICP_GG004>, int)> GetListAsync
            (int tenant, int pageSize, int page, string? search, int? codigo, bool isActive);
        Task<CSICP_GG004?> GetByIdAsync(string id, int tenant);
        Task<CSICP_GG004> CreateAsync(CSICP_GG004 gg004);
    }
}
