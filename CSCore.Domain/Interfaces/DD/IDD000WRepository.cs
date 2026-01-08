using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.DD;

public interface IDD000WRepository : IRepositorioBase<CSICP_DD000W>
{
    Task<CSICP_DD000W?> GetByIdAsync(string dd000Id, int tenantId);
    Task<(List<CSICP_DD000W>, int)> GetListAsync(int tenantId, string? dd000ConfigId, int pageNumber, int pageSize);
}