using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._03X
{
    public interface IGG036Repository : IRepositorioBase<CSICP_GG036>
    {
        Task<(IEnumerable<CSICP_GG036>, int)> GetListAsync(
            int tenant,
            string IDEstabelecimento,
            string IDProduto,
            string IDGrupo,
            DateTime? data,
            int pageSize,
            int page);
    }
}
