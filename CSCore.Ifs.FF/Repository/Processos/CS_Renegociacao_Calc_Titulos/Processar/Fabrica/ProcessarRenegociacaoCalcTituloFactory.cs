using CSCore.Domain;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;

using CSLB900.MSTools.CalculoAdicaoDataStrategy;
using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar.Fabrica
{
    public class PrmRenegociacaoCalcTituloFactory
    {
        public Prm_Renegociacao_Calc_Simulacao_Titulos prmSimulacao { get; set; } = null!;
        public CSICP_Bb008 work_bb008 { get;set;} = null!;
        public AppDbContext appDbContext { get; set; } = null!;
        public ICS_GenerateId generateId { get; set; } = null!;
        public string[] aux_condicaoPagtoDividida { get; set; } = null!;
        public int workQtdParcelas { get; set; } = 0;
        public decimal work_valor_entrada { get; set; } = 0;
    }
    public class ProcessarRenegociacaoCalcTituloFactory
    {
        public static IAuxProcessarCalculoTitulo Create(PrmRenegociacaoCalcTituloFactory prm)
        {
            //tipo dias
            if (IsTipoDias(prm.prmSimulacao, prm.work_bb008))
            {
                return new ProcessarCalculoTituloTipoDias(
                    prm.appDbContext, prm.generateId, prm.aux_condicaoPagtoDividida, prm.work_valor_entrada);
            }

            //tipo parcela dia
            else if (IsTipoParcelaDias(prm.prmSimulacao, prm.work_bb008))
            {
                return new ProcessarParcelasTipoParcelaDiasOuMes(
                    prm.generateId, prm.aux_condicaoPagtoDividida,
                    prm.work_valor_entrada, prm.appDbContext, incrementarDataStrategy: new IncrementarDataTipoParcelaDiaStrategy());
            }

            //tipo parcela mes
            else if (IsTipoParcelaMes(prm.prmSimulacao, prm.work_bb008))
            {
                return new ProcessarParcelasTipoParcelaDiasOuMes(
                    prm.generateId,
                    prm.aux_condicaoPagtoDividida,
                    prm.work_valor_entrada,
                    prm.appDbContext,
                    incrementarDataStrategy: new IncrementarDataTipoParcelaMesStrategy());
            }

            //a vista
            else if (IsTipoAVista(prm.prmSimulacao, prm.work_bb008))
            {
                return new ProcessarCalculoTipoAVista(prm.appDbContext, prm.generateId);
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
