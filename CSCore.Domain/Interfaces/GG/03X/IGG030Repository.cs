using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._03X
{
    public interface IGG030Repository : IRepositorioBase<CSICP_GG030>
    {
        Task<(IEnumerable<CSICP_GG030>, int)> GetListAsync(
            int tenant,
            string? search,
            int? GG030Status_ID,
             string? in_estabID,
            DateTime DataInicial,
            DateTime DataFinal, int pageSize, int page);

        Task<(IEnumerable<CSICP_GG030Est>, int)> GetListGG030EstAsync(int tenant,string? gg030_id, int pageSize, int page);
        Task<CSICP_GG030?> GetByIdAsync(string id, int tenant);
        Task<CSICP_GG030?> GetByIdParaUpdateAsync(string id, int tenant);

        Task<bool> DeleteGg030Est(long id, int tenant);
        Task<string> CreateGg030Est(CSICP_GG030Est entity);
    }
}
