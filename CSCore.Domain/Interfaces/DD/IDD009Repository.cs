using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.DD
{
    public interface IDD009Repository : IRepositorioBaseV2ComGets<CSICP_DD009>
    {
        Task<CSICP_DD009?> GetByIdAsync(string id, int tenant);

        Task<(IEnumerable<CSICP_DD009> Data, int TotalCount)> GetAllAsyncComPaginacao(
            IEnumerable<FiltrosDinamicos> filtros,
            int pageNumber,
            int pageSize);
    }
}