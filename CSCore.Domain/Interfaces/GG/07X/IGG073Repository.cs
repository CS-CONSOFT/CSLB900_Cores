using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._07X
{
    public interface IGG073Repository : IRepositorioBase<CSICP_GG073>
    {
        Task<(IEnumerable<CSICP_GG073>, int)> GetListAsync(int tenant, int pageSize, int page, string? Protocolo, string? BB001_EstabID,
            DateTime DataInicial,
            DateTime DataFinal, string? BB005_CentroCustoID, string? GG001_AlmoxID, int? GG073_StatusID, int? GG073_TMov_ID);

        Task BaixaEstoque(string GG073_ID, int tenant);

        Task<CSICP_GG073?> GetByIdAsync(string id, int tenant);
        Task UpdateGG073StatusId(CSICP_GG073 entidadeParaAtualizar, int gg073Sta_fechado_id);
    }
}
