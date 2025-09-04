using CSCore.Domain;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.AvaliarCondicaoPagamento
{
    public static class CondicaoPagamentoAvaliador
    {

        public static int AvaliarCondicaoPagamento(
            Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos,
            CSICP_Bb008 work_bb008, string[]? aux_condicaoPagtoDividida)
        {
            var strategy = CondicaoPgtoStrategyFactory.Criar(in_Renegociacao_Calc_Titulos, work_bb008);
            return strategy.AvaliarCondicaoPagamento(aux_condicaoPagtoDividida);
        }

      
    }
}
