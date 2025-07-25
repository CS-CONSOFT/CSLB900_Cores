using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._01X
{
    public interface IGG016fRepository : IRepositorioBase<CSICP_GG016f>
    {
        Task<IEnumerable<CSICP_GG016f>> GetListAsync(int tenant, long gg016e_id);
        Task<CSICP_GG016f?> GetByIdAsync(long id, int tenant);
        Task<CSICP_GG016f> CreateAsync(CSICP_GG016f entity);
    }
}

