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
            int in_StID_bb008_tp_ParcelaDias,
            int in_StID_bb008_tp_ParcelaMes,
            int in_StID_bb008_tp_Dias,
            CSICP_Bb008 work_bb008)
        {
            if (EhTipoDias(in_StID_bb008_tp_Dias, work_bb008))
                return new TipoDiasCondicaoPgtoStrategy();

            if (EhTipoParcelaDiasOuMes(in_StID_bb008_tp_ParcelaDias, in_StID_bb008_tp_ParcelaMes, work_bb008))
                return new TipoParcelaDiasOuMesPgtoStrategy();

            throw new NotSupportedException("Tipo de condição de pagamento não suportado.");
        }

        private static bool EhTipoParcelaDiasOuMes
            (int in_StID_bb008_tp_ParcelaDias, int in_StID_bb008_tp_ParcelaMes, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_StID_bb008_tp_ParcelaDias
                || work_bb008.Bb008Tipoid == in_StID_bb008_tp_ParcelaMes;
        }

        private static bool EhTipoDias
            (int in_StID_bb008_tp_Dias, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_StID_bb008_tp_Dias;
        }
    }
}
