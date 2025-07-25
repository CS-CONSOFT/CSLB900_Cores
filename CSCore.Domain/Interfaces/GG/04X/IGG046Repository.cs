using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.GG._04X
{
    public interface IGG046Repository : IRepositorioBase<OsusrE9aCsicpGg046>
    {
        Task<(IEnumerable<OsusrE9aCsicpGg046>, int)> GetListAsync(
            int tenant,
            int pageSize,
            int page);
        Task<OsusrE9aCsicpGg046?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<OsusrE9aCsicpGg046>> GetListPeloGG045Async(int tenant, string gg045Id);
    }
}
