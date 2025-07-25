using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._00X.GG008
{
    public interface IGG008eRepository : IRepositorioBase<CSICP_GG008e>
    {
        Task<CSICP_GG008e> GetByIdAsync(string gg008e_id, string produtoGG008_ID, int tenant);
        Task<(IEnumerable<CSICP_GG008e>, int)> GetListAsync(int tenant, string produtoGG008_ID, int pageSize, int page);
    }
}
