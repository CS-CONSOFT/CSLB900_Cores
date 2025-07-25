using CSCore.Domain.CS_Models.CSICP_TT;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.TT.TT0XX
{
    public interface ITT031Repository : IRepositorioBase<CSICP_TT031>
    {
        Task<(IEnumerable<RepoTT031>, int)> GetListAsync(int tenant, long in_tt030_id,
            int pageSize,
            int page);
    }
}
