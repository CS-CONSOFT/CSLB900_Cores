using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._00X
{
    public interface IGG000Repository : IRepositorioBase<CSICP_GG000>
    {
        Task<(IEnumerable<CSICP_GG000>, int)> GetListAsync(int tenant, int pageSize, int page);
        Task<CSICP_GG000?> GetByIdAsync(long id, int tenant);
        Task<int> RecuperaUltimoCodigo(int tenant);
    }
}
