using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.GG
{
    public interface IGG002Repository : IRepositorioBaseMudaAtivo<CSICP_GG002>
    {
        Task<(IEnumerable<CSICP_GG002>, int)> GetListAsync(int tenant,int pageSize, int page, string? search, bool? isActive = true);
        Task<CSICP_GG002?> GetByIDAsync(string id, int tenant);
    }
}
