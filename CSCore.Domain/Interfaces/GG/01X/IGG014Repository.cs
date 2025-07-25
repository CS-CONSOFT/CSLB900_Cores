using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.GG._01X
{
    public interface IGG014Repository : IRepositorioBaseMudaAtivo<CSICP_GG014>
    {
        Task<(IEnumerable<CSICP_GG014>, int)> GetListAsync(int tenant,int pageSize, int page, string? search, bool isActive);
        Task<CSICP_GG014?> GetByIdAsync(string id, int tenant);
    }
}
