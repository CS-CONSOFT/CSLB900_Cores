using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._07X
{
    public interface IGG074Repository : IRepositorioBase<CSICP_GG074>
    {
        Task<(IEnumerable<CSICP_GG074>, int)> GetListAsync(int tenant, string? GG073_ID, int pageSize, int page);
        Task<CSICP_GG074?> GetByIdAsync(int tenant, long id);
    }
}
