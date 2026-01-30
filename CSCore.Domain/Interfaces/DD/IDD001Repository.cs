using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.DD
{
    public interface IDD001Repository : IRepositorioBaseV2ComGets<CSICP_DD001>
    {
        Task<CSICP_DD001?> GetByIdAsync(string id, int tenant);
        Task<(IEnumerable<CSICP_DD001> Data, int TotalCount)> GetAllAsyncComPaginacao(
            IEnumerable<FiltrosDinamicos> filtros,
            int pageNumber,
            int pageSize);
    }
}