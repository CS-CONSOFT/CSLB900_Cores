using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG
{
    public interface IGG003Repository : IRepositorioBaseMudaAtivo<CSICP_GG003>
    {
        Task<CSICP_GG003> CreateAsync(CSICP_GG003 gg003);
        Task<(IEnumerable<CSICP_GG003>, int)> GetListAsync(int tenant, int pageSize, int page, string? search, bool isActive);
        Task<IEnumerable<CSICP_BB001>> GetListaEstabelecimentoParaGrupo(int tenant);
        Task<CSICP_GG003?> GetByIdAsync(string id, int tenant);
    }
}
