using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._00X
{
    public interface IGG007Repository : IRepositorioBaseMudaAtivo<CSICP_GG007>
    {
        Task<(IEnumerable<CSICP_GG007>, int)> GetListAsync
            (int tenant, int pageSize, int page, string? search, string? unidade, bool? isActive = true);
        Task<CSICP_GG007?> GetByIdAsync(string id, int tenant);
    }
}
