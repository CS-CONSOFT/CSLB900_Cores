using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.GG._00X
{
    public interface IGG011Repository : IRepositorioBaseMudaAtivo<CSICP_GG011>
    {
        Task<(IEnumerable<CSICP_GG011>, int)> GetListAsync(int tenant,int pageSize, int page, string? search, string? codigo, bool isActive = true);
        Task<CSICP_GG011?> GetByIdAsync(string id, int tenant);
        Task<CSICP_GG011> CreateAsync(CSICP_GG011 gg011);
    }
}
