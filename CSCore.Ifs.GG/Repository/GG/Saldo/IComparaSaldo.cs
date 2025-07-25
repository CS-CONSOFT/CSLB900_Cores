using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Ifs.GG.Repository.GG.Saldo
{
    public interface IComparaSaldo
    {
        Task<(CSICP_GG520? saldoAtual, int Ret_ComprometeSaldo)> CS_RI_CompSaldo
            (int in_tenant,
            string in_saldoID_origem,
            string in_saldoID_Destino,
            decimal in_Qtda,
            string in_idOrigem,
            DateTime in_DataMovimento, string in_usuarioID,
            string in_protocoloDOC,
            string in_docID,
            int in_Prm_EntSaida_GG073_ID,
            int in_StID_EntSai_GG073_Saida_ID,
            int in_StID_EntSai_GG028_Saida_ID,
            int in_StID_EntSai_GG028_Entrada_ID,
            int in_StID_Gg028NatId,
            int in_StID_StaticaSimNao_SIM_id);
    }
}
