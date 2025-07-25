using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.GG
{
    public interface IGG005Repository : IRepositorioBaseMudaAtivo<CSICP_GG005>
    {
        Task<(IEnumerable<CSICP_GG005>, int)> GetListAsync(int tenant,int pageSize, int page, string? search, int? codigo, bool isActive);
        Task<CSICP_GG005?> GetByIdAsync(string id, int tenant);
    }
}
