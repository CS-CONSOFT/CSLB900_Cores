using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._00X.GG008
{
    public interface IGG008aRepository : IRepositorioBase<CSICP_GG008a>
    {
        Task<CSICP_GG008a> GetByIdAsync(string gg008a_id, string produtoGG008_ID, int tenant);
        Task<(IEnumerable<CSICP_GG008a>, int)> GetListAsync(int tenant, string produtoGG008_ID, int pageSize, int page);
    }
}
