using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.DD
{
    public interface IDD013Repository : IRepositorioBaseV2ComGets<CSICP_DD013>
    {
        Task<CSICP_DD013?> GetByIdAsync(string id, int tenant);
        Task<(IEnumerable<CSICP_DD013> Data, int TotalCount)> GetAllAsyncComPaginacao(
            IEnumerable<FiltrosDinamicos> filtros,
            int pageNumber,
            int pageSize);
    }
}