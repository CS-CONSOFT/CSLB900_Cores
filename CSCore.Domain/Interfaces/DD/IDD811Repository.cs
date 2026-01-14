using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.DD
{
    public interface IDD811Repository : IRepositorioBaseV2ComGets<CSICP_DD811>
    {
        Task<CSICP_DD811?> GetByIdAsync(string id, int tenant);
        Task<(IEnumerable<CSICP_DD811> Data, int TotalCount)> GetAllAsyncComPaginacao(
            IEnumerable<FiltrosDinamicos> filtros,
            int pageNumber,
            int pageSize);
    }
}