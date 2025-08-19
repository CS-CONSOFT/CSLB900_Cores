using CSCore.Domain;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Interface;
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
        public static IProcessarCalculoTitulo Create(
            Prm_Renegociacao_Calc_Titulos in_Renegociacao_Calc_Titulos,
            CSICP_Bb008 work_bb008,
            (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) in_calculoFinanciamento,
            AppDbContext appDbContext,
            ICS_GenerateId generateId,
            string[] aux_condicaoPagtoDividida,
            int work_qtd_parcelas,
            decimal work_valor_entrada)
        {
            //tipo dias
            if (work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_Dias)
            {
                return new ProcessarCalculoTituloTipoDias(appDbContext, generateId, aux_condicaoPagtoDividida, work_valor_entrada);
            }

            //tipo parcela dia
            else if (work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaDias)
            {
                return new ProcessarParcelasTipoParcelaDiasOuMes(generateId, aux_condicaoPagtoDividida, work_qtd_parcelas, isParcelaMes: false, work_valor_entrada, appDbContext);
            }

            //tipo parcela mes
            else if (work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_ParcelaMes)
            {
                return new ProcessarParcelasTipoParcelaDiasOuMes(generateId, aux_condicaoPagtoDividida, work_qtd_parcelas, isParcelaMes: true, work_valor_entrada, appDbContext);
            }

            //a vista
            else if (work_bb008.Bb008Tipoid == in_Renegociacao_Calc_Titulos.in_StID_bb008_tp_A_vista)
            {
                return new ProcessarCalculoTipoAVista(appDbContext, generateId);
            }
            throw new NotSupportedException("Tipo de renegociação não suportado.");
        }
    }
}
