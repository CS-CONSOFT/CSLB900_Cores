using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._03X
{

    public interface IGG032Repository : IRepositorioBase<CSICP_GG032>
    {
        Task<(IEnumerable<CSICP_GG032>, int)> GetListAsync(int tenant, int pageSize, int page,
             string? search,
             int? GG032Status_ID,
             int? codigo,
             DateTime DataInicial,
             DateTime DataFinal);
        Task<CSICP_GG032?> GetByIdAsync(int tenant, string id);
    }
}
