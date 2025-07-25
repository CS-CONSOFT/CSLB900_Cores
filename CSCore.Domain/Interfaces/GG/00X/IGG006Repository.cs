using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.GG._00X
{
    public interface IGG006Repository : IRepositorioBaseMudaAtivo<CSICP_GG006>
    {
        Task<(IEnumerable<CSICP_GG006>, int)> GetListAsync(int tenant,int pageSize, int page, string? search,int? codigo, bool? isActive = true);
        Task<CSICP_GG006?> GetByIdAsync(string id, int tenant);
    }
}
