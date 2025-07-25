using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._00X.GG008
{
    public interface IGG008pRepository : IRepositorioBase<CSICP_GG008p>
    {
        Task<CSICP_GG008p> GetByIdAsync(string gg008p_id, string produtoGG008Kdx_ID, int tenant);
        Task<(IEnumerable<CSICP_GG008p>, int)> GetListAsync(int tenant, string produtoGG008Kdx_ID, int pageSize, int page);
    }
}
