using CSCore.Domain;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.AvaliarCondicaoPagamento
{
    public static class CondicaoPgtoStrategyFactory
    {
        public static IAvaliarCondicaoPgtoStrategy Criar(
            Prm_Renegociacao_Calc_Simulacao_Titulos titulos,
            CSICP_Bb008 work_bb008)
        {
            if (EhTipoDias(titulos, work_bb008))
                return new TipoDiasCondicaoPgtoStrategy();

            if (EhTipoParcelaDiasOuMes(titulos, work_bb008))
                return new TipoParcelaDiasOuMesPgtoStrategy();

            throw new NotSupportedException("Tipo de condição de pagamento não suportado.");
        }

        private static bool EhTipoParcelaDiasOuMes
            (Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaDias
                || work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaMes;
        }

        private static bool EhTipoDias
            (Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_Dias;
        }
    }
}
