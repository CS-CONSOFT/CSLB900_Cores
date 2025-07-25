using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG
{
    public interface IGG001Repository : IRepositorioBaseMudaAtivo<CSICP_GG001>
    {
        Task<(IEnumerable<CSICP_GG001>, int)> GetListAsync
            (int tenant, string? estabID, string? codAlmox, int pageSize, int page, string? search, bool isAtivo);
        Task<CSICP_GG001?> GetByIdAsync(string id, int tenant);
    }
}
