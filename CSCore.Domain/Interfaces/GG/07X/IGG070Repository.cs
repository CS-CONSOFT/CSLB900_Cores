using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._07X
{
    public interface IGG070Repository : IRepositorioBase<CSICP_GG070>
    {
        Task<(IEnumerable<CSICP_GG070>, int)> GetListAsync(int tenant, int pageSize, int page, DateTime DataInicio, DateTime DataFinal);
        Task<CSICP_GG070?> GetByIdAsync(int tenant, long id);
    }
}
