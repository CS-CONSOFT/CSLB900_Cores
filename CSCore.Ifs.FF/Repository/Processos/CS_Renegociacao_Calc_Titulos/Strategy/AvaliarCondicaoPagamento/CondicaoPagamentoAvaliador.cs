using CSCore.Domain;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.AvaliarCondicaoPagamento
{
    public static class CondicaoPagamentoAvaliador
    {
        public static (int aux_entrada, int aux_qtdParcelas) AvaliarCondicaoPagamento(
            Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008, string[]? aux_condicaoPagtoDividida)
        {
            IAvaliarCondicaoPgtoStrategy strategy;
            if (EhTipoDias(in_Renegociacao_Calc_Titulos, work_bb008))
                strategy = new TipoDiasCondicaoPgtoStrategy();
            else if(EhTipoParcelaDiasOuMes(in_Renegociacao_Calc_Titulos, work_bb008))
                strategy = new TipoParcelaDiasOuMesPgtoStrategy();
            else throw new NotSupportedException("Tipo de condição de pagamento não suportado.");

            return strategy.AvaliarCondicaoPagamento(aux_condicaoPagtoDividida);
        }

        private static bool EhTipoParcelaDiasOuMes(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaDias || work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaMes;
        }

        private static bool EhTipoDias(Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_Dias;
        }
    }
}
