using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._00X
{
    public interface IGG008KdxRepository : IRepositorioBase<CSICP_GG008Kdx>
    {
        Task<CSICP_GG008Kdx> CreateAsyncc(CSICP_GG008Kdx entity, CSICP_GG008p entity_gg008p, CSICP_GG520 cSICP_GG520);
        Task<CSICP_GG008Kdx> UpdateAsync(string kdxID, int tenant, CSICP_GG008Kdx entity, CSICP_GG008p entity_gg008p);
        Task<CSICP_GG008Kdx> UpdateMoedaAsync(string kdxID, int tenant, string? Gg008Moedaid, decimal? valorMoeda, string produtoID);
        Task UpdateTodasMoedaAsync(int tenant, string? Gg008Moedaid, decimal? valorMoeda, string produtoID);
        Task<CSICP_GG008Kdx?> GetByIdAsync(string gg008KdxID, string produtoGG008_ID, int tenant);
        Task<CSICP_GG008Kdx?> GetByIdSimplesParaAtualizarAsync(string gg008KdxID, int tenant);
        Task<CSICP_GG008Kdx?> GetByIdPorEmpresaParaExibicaoAsync(string? BB001_filialID, string produtoGG008_ID, int tenant);
        Task<(IEnumerable<CSICP_GG008Kdx>, int)> GetListAsync(int tenant, string produtoGG008_ID, bool? isActive, int pageSize, int page);
        Task<List<CSICP_GG008Kdx>> GetListAsyncParaPesquisaParaProdutoS(
            int tenant, string produtoGG008_ID);
    }
}
