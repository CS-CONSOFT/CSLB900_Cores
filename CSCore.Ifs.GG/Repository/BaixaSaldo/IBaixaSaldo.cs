using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Ifs.GG.Repository.BaixaSaldo
{
    public interface IBaixaSaldo
    {

        Task<STATUS_SALDO> CS_BaixarSaldo(
            int in_tenant,
            string? in_G520_ID_origem,
            string? in_protocolo,
            string? in_programaOrigem,
            string? in_usuarioID,
            string? IN_GG028_ORIGEM_PKID,
            string? IN_GG028_ORIGEM_DOC_PKID,
            DateTime in_DataMovimento,
            decimal in_quantidadeASerBaixada,

            //staticas
            int in_Prm_EntSaida_GG073EntSaida_ID,
            int in_StID_EntSai_GG073_Saida_ID,
            int in_StID_EntSai_GG028_Saida_ID,
            int in_StID_EntSai_GG028_Entrada_ID,
            int in_StID_Gg028NatId,
            int in_StID_StaticaSimNao_SIM_id);


        Task BaixaSaldoAumentandoEstoque(DateTime Movimento_DataMovimento, decimal QuantidadeASerBaixada, CSICP_GG520 gg520_encontrada);
        Task BaixaSaldoSubtraindoEstoque(DateTime Movimento_DataMovimento, decimal QuantidadeASerBaixada, CSICP_GG520 gg520_encontrada);
        Task AtualizaStatusDaGG074(CSICP_GG074 navCurrentGG074, int estado_saldo);
    }
}
