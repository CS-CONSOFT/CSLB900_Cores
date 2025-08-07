using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.GG._04X
{
    public interface IGG046Repository : IRepositorioBase<CSICP_GG046>
    {
        Task<(IEnumerable<CSICP_GG046>, int)> GetListAsync(
            int tenant,
            int pageSize,
            int page);
        Task<CSICP_GG046?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_GG046>> GetListPeloGG045Async(int tenant, string gg045Id);
    }
}
