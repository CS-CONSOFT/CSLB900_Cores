using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._04X
{
    public interface IGG045Repository : IRepositorioBase<CSICP_GG045>
    {
        Task<(IEnumerable<CSICP_GG045>, int)> GetListAsync(int tenant, int pageSize, int page, 
            string? SearchDescricao, string? VSerieNF, string? VNumNF, DateTime DataInicial, DateTime DataFinal);
        Task<CSICP_GG045?> GetByIdAsync(int tenant, string id);

        Task ProcessarTransferenciaDeSaldo(
            int in_tenant,
            string in_gg045_id,
            int in_StID_csicp_gg045_Stat_Aberto,
            int in_StID_csicp_gg045_Stat_Transferido,
            int in_StID_csicp_gg046_Stat_Saida,
            int in_Prm_EntSaida_GG073EntSaida_Entrada_ID,
            int in_StID_EntSai_GG073_Saida_ID,
            int in_StID_EntSai_GG028_Saida_ID,
            int in_StID_EntSai_GG028_Entrada_ID,
            int in_StID_Gg028NatId,
            int in_StID_StaticaSimNao_SIM_id);
            
    }
}
