using CSCore.Domain;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar.Fabrica
{
    public class ProcessarRenegociacaoCalcTituloFactory
    {
        public static IAuxProcessarCalculoTitulo Create(
            Prm_Renegociacao_Calc_Simulacao_Titulos prmSimulacao,
            CSICP_Bb008 work_bb008,
            AppDbContext appDbContext,
            ICS_GenerateId generateId,
            string[] aux_condicaoPagtoDividida,
            int work_qtd_parcelas,
            decimal work_valor_entrada)
        {
            //tipo dias
            if (IsTipoDias(prmSimulacao, work_bb008))
            {
                return new ProcessarCalculoTituloTipoDias(
                    appDbContext, generateId, aux_condicaoPagtoDividida, work_valor_entrada);
            }

            //tipo parcela dia
            else if (IsTipoParcelaDias(prmSimulacao, work_bb008))
            {
                return new ProcessarParcelasTipoParcelaDiasOuMes(
                    generateId, aux_condicaoPagtoDividida, work_qtd_parcelas, isParcelaMes: false,
                    work_valor_entrada, appDbContext);
            }

            //tipo parcela mes
            else if (IsTipoParcelaMes(prmSimulacao, work_bb008))
            {
                return new ProcessarParcelasTipoParcelaDiasOuMes(
                    generateId,
                    aux_condicaoPagtoDividida,
                    work_qtd_parcelas,
                    isParcelaMes: true,
                    work_valor_entrada,
                    appDbContext);
            }

            //a vista
            else if (IsTipoAVista(prmSimulacao, work_bb008))
            {
                return new ProcessarCalculoTipoAVista(appDbContext, generateId);
            }
            throw new NotSupportedException("Tipo de renegociação não suportado.");
        }

        private static bool IsTipoAVista(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_A_vista;
        }

        private static bool IsTipoParcelaMes(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaMes;
        }

        private static bool IsTipoParcelaDias(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaDias;
        }

        private static bool IsTipoDias(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_Dias;
        }
    }
}
