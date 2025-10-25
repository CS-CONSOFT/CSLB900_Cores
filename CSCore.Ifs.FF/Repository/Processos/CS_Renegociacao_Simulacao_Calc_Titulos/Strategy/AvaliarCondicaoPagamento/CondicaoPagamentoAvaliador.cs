using CSCore.Domain;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.AvaliarCondicaoPagamento
{
    public static class CondicaoPagamentoAvaliador
    {

        public static int AvaliarCondicaoPagamento(
            int in_StID_bb008_tp_ParcelaDias,
            int in_StID_bb008_tp_ParcelaMes,
            int in_StID_bb008_tp_Dias,
            CSICP_Bb008 work_bb008, string[]? aux_condicaoPagtoDividida)
        {
            var strategy = CondicaoPgtoStrategyFactory.Criar(
                in_StID_bb008_tp_ParcelaDias,
                in_StID_bb008_tp_ParcelaMes,
                in_StID_bb008_tp_Dias,
                work_bb008);
            return strategy.AvaliarCondicaoPagamento(aux_condicaoPagtoDividida);
        }

      
    }
}
