using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._01X
{
    public interface IGG016eRepository : IRepositorioBase<CSICP_GG016e>
    {
        Task<IEnumerable<CSICP_GG016e>> GetListAsync(int tenant, string? search);
        Task<CSICP_GG016e?> GetByIdAsync(long id, int tenant);
    }
}
