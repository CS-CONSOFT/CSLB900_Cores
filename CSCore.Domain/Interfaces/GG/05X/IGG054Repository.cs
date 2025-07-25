using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_QueryFilters.Specific;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._05X
{
    public interface IGG054Repository : IRepositorioBase<CSICP_GG054>
    {
        Task<(IEnumerable<CSICP_GG054>, int)> GetListAsync(int tenant, int pageSize, int page,
            string? Search, string? GG001_ID, int? GG054_StatusID, DateTime DataInicial, DateTime DataFinal);
        Task<CSICP_GG054?> GetByIdAsync(int tenant, long id);
        Task GerarInventario(GG054GeraInventarioParametros gG054GeraInventarioParametros);
    }
}
