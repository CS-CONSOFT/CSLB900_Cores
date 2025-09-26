using CSCore.Domain;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Eventos.Repository;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Parametro;
using CSCore.Ifs.LB900.AdapterGerarValores;
using CSLB900.MSTools.CalculoAdicaoDataStrategy;
using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar.Fabrica
{
     public class CreateParaMemoriaCalculoFF043Params
        {
        public CreateParaMemoriaCalculoFF043Params()
        {
        }

        public int In_StID_bb008_tp_Dias { get; set; }
            public int In_StID_bb008_tp_ParcelaDias { get; set; }
            public int In_StID_bb008_tp_ParcelaMes { get; set; }
            public int In_StID_bb008_tp_A_vista { get; set; }
            public int InTipoBB008_ID_Recuperada { get; set; }
            public IGenerateProtocolo InGenerateProtocolo { get; set; } = null!;
            public ICS_GenerateId InGenerateId { get; set; } = null!;
            public string InEmpresaID { get; set; } = null!;
            public int InNumeroParcela { get; set; }
            public decimal InValorEntrada { get; set; }
            public AppDbContext InAppDbContext { get; set; } = null!;
        }
   public class PrmRenegociacaoCalcTituloFactory
    {
        public Prm_Renegociacao_Calc_Simulacao_Titulos prmSimulacao { get; set; } = null!;
        public CSICP_Bb008 work_bb008 { get; set; } = null!;
        public AppDbContext appDbContext { get; set; } = null!;
        public ICS_GenerateId generateId { get; set; } = null!;
        public string[] aux_condicaoPagtoDividida { get; set; } = null!;
        public int workQtdParcelas { get; set; } = 0;
        public decimal work_valor_entrada { get; set; } = 0;
    }


    /*CLASSE*/
    public class ProcessarRenegociacaoCalcTituloFactory
    {
        /*CREATE USADO NO FLUXO DE CALCULO DA RENEGOCIACAO*/
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


        /*CREATE USADO NO FLUXO DE MEMORIA PARA FF043*/
        public static IAuxProcessarCalculoTitulo CreateParaMemoriaCalculoFF043(CreateParaMemoriaCalculoFF043Params prm)
        {
            if (IsTipoParcelaDias(prm.InTipoBB008_ID_Recuperada, prm.In_StID_bb008_tp_ParcelaDias))
            {
                var prmGeraMemoriaCalculo
                = new ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input(
                    GenerateProtocolo: prm.InGenerateProtocolo,
                    GenerateId: prm.InGenerateId,
                    EmpresaID: prm.InEmpresaID,
                    Aux_condicaoPagtoDividida: string.Join(";", prm.InNumeroParcela, 0, 30).Split(';'),
                    Work_valor_entrada: prm.InValorEntrada,
                    AppDbContext: prm.InAppDbContext,
                    IncrementarDataStrategy: new IncrementarDataTipoParcelaDiaStrategy()
                );
                return new ProcessarParcelasTipoParcelaDiasOuMesParaFF043(prmGeraMemoriaCalculo);
            }
            throw new NotSupportedException("Tipo de renegociação não suportado.");
        }




        /*PRIVATE*/


        private static bool IsTipoAVista(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_A_vista;
        }

        private static bool IsTipoAVista(int InBB008Tp_ID, int InBB008TpAVista_ID)
        {
            return InBB008Tp_ID == InBB008TpAVista_ID;
        }

        private static bool IsTipoParcelaMes(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaMes;
        }

        private static bool IsTipoParcelaMes(int InBB008Tp_ID, int InBB008TpMes_ID)
        {
            return InBB008TpMes_ID == InBB008Tp_ID;
        }

        private static bool IsTipoParcelaDias(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaDias;
        }


        private static bool IsTipoParcelaDias(int InBB008Tp_ID, int InBB008TpParcelaDias_ID)
        {
            return InBB008TpParcelaDias_ID == InBB008Tp_ID;
        }

        private static bool IsTipoDias(Prm_Renegociacao_Calc_Simulacao_Titulos in_Renegociacao_Calc_Titulos, CSICP_Bb008 work_bb008)
        {
            return work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_Dias;
        }

        private static bool IsTipoDias(int InBB008Tp_ID, int InBB008TpDias_ID)
        {
            return InBB008Tp_ID == InBB008TpDias_ID;
        }
    }
}
