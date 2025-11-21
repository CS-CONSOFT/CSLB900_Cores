using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.GG._00X
{
    public interface IGG009Repository : IRepositorioBaseMudaAtivo<CSICP_GG009>
    {
        Task<(IEnumerable<CSICP_GG009>, int)> GetListAsync(int tenant,int pageSize, int page, string? search, string? code, bool? isActive = true);
        Task<CSICP_GG009?> GetByIdAsync(string id, int tenant);
        Task<CSICP_GG009> CreateAsync(CSICP_GG009 CSICP_GG009);
    }
}
