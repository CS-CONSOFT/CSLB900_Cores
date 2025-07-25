using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._02X
{
    public interface IGG022Repository : IRepositorioBase<CSICP_GG022>
    {
        Task<(IEnumerable<CSICP_GG022>, int)> GetListAsync(int tenant, int pageSize, int page, string? Gg022Ncmid, string? Gg022Ufid, decimal? Gg022Pfcp);
        Task<CSICP_GG022?> GetByIdAsync(int tenant, string id, string? Gg022Ncmid, string? Gg022Ufid, decimal? Gg022Pfcp);
    }
}
