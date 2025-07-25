using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.GG._02X
{
    public interface IGG021Repository : IRepositorioBaseMudaAtivo<CSICP_GG021>
    {
        Task<(IEnumerable<CSICP_GG021>, int)> GetListAsync(int tenant,int pageSize, int page, string? search, string? codigo, bool isActive);
        Task<CSICP_GG021?> GetByIdAsync(string id, int tenant);
    }
}
