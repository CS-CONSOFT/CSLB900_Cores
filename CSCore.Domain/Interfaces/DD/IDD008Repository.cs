using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.DD
{
    public interface IDD008Repository : IRepositorioBaseV2ComGets<CSICP_DD008>
    {
        Task<CSICP_DD008?> GetByIdAsync(string id, int tenant);
        Task<(IEnumerable<CSICP_DD008> Data, int TotalCount)> GetAllAsyncComPaginacao(
            IEnumerable<FiltrosDinamicos> filtros,
            int pageNumber,
            int pageSize);
    }
}