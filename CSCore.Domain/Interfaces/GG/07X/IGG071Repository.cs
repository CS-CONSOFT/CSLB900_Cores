using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._07X
{
    public interface IGG071Repository : IRepositorioBase<CSICP_GG071>
    {
        Task<(IEnumerable<CSICP_GG071>, int)> GetListAsync(int tenant, int pageSize, int page,
            DateTime DataInicio, DateTime DataFinal, string? Protocolo,
            string? BB005_CentroDeCusto_ID, int? GG071_Status_ID, int? GG041_TpReq_ID, string? SY001_UsuarioID,
            string? BB001_EstabID);
        Task<CSICP_GG071?> GetByIdAsync(int tenant, long id);

        Task CancelarRI(
            int tenant,
            long g071ID,
            int csicp_gg071_sta_aberto_id,
            int csicp_gg071_sta_solicitado_id,
            int csicp_gg071_sta_cancelado_id);

        Task ExcluirRI(int tenant, long g071ID, long csicp_gg071_sta_aberto_id);
        Task UpdateRIStatus(int tenant, long g071ID, int novoStatusGG071id);
        Task NormalizarRI(int tenant, long g071ID);

        Task<(int retCountSaldo, int retCountContagem, bool isOk)> Requisitar_RI_Solicitacao(
            int tenant,
            long g071ID,
            int csicp_gg072_stq_Aberto_id,
            int csicp_gg071_sta_solicitado_id,
            int csicp_gg028_tipo_reqInterna_id);

        Task CS_RI_Processa_Baixa(
            int in_tenant,
            string in_usuarioID,
            long in_RI_ID_gg071,
            int in_StID_csicp_gg071_sta_solicitado,
            int in_StID_csicp_gg071_sta_erro,
            int in_StID_gg028_natOperacao_ReqInterna_ID,
            int in_StIDgg073_ent_saida_saida_ID,
            int in_StIDgg028_ent_saida_saida_ID,
            int in_StIDgg028_ent_saida_ent_ID,
            int in_StID_csicp_gg072_stq_Inventario,
            int in_StID_csicp_gg072_stq_SemSaldo,
            int in_StID_csicp_gg072_stq_Erro,
            int in_StID_csicp_gg072_stq_Baixado,
            int in_StID_csicp_gg071_StatusId_Erro,
            int in_StID_csicp_gg071_StatusId_Atentido,
            int in_StID_estatica_sim_id);
    }
}
