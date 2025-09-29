using System;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.Parametros;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.ParcelaTipoAVista;
using CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102.ParcelaTipoDia;
using CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Processar;
using CSLB900.MSTools.CalculoAdicaoDataStrategy;

namespace CSCore.Ifs.FF.Repository.Processos.CS_GeraMemoriaCalculoFF043_FF102;

public class GerarMemoriaCalcFF04XFactory
{
     /*CREATE USADO NO FLUXO DE CALCULO DA RENEGOCIACAO*/
          /*CREATE USADO NO FLUXO DE MEMORIA PARA FF043*/
        public static IAuxProcessarCalculoTitulo RetornaInstanciaParaExecutarOCalculo(CreateParaMemoriaCalculoFF043Params prm)
        {
            if (IsTipoParcelaDias(prm.InTipoBB008_ID_Recuperada, prm.In_StID_bb008_tp_ParcelaDias))
            {
                var prmGeraMemoriaCalculo
                = new ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input(
                    Protocolo: prm.Protocolo,
                    GenerateId: prm.InGenerateId,
                    EmpresaID: prm.InEmpresaID,
                    Aux_condicaoPagtoDividida: string.Join(";", prm.InNumeroDeParcelas, 0, 30).Split(';'),
                    Work_valor_entrada: prm.InValorEntrada,
                    AppDbContext: prm.InAppDbContext,
                    IncrementarDataStrategy: new IncrementarDataTipoParcelaDiaStrategy()
                );
                return new ProcessarParcelasTipoParcelaDiasOuMesParaFF043(prmGeraMemoriaCalculo);
            }
            
            //tipo parcela dia
            else if (IsTipoParcelaMes(prm.InTipoBB008_ID_Recuperada, prm.In_StID_bb008_tp_ParcelaMes))
            {
                 var prmGeraMemoriaCalculo
                    = new ProcessarParcelasTipoParcelaDiasOuMesParaFF043Input(
                    Protocolo: prm.Protocolo,
                    GenerateId: prm.InGenerateId,
                    EmpresaID: prm.InEmpresaID,
                    Aux_condicaoPagtoDividida: string.Join(";", prm.InNumeroDeParcelas, 0, 30).Split(';'),
                    Work_valor_entrada: prm.InValorEntrada,
                    AppDbContext: prm.InAppDbContext,
                    IncrementarDataStrategy: new IncrementarDataTipoParcelaMesStrategy()
                );
                return new ProcessarParcelasTipoParcelaDiasOuMesParaFF043(prmGeraMemoriaCalculo);
            }

            //tipo parcela mes
            else if (IsTipoDias(prm.InTipoBB008_ID_Recuperada, prm.In_StID_bb008_tp_Dias))
            {
                return new ProcessarParcelasTipoParcelaDiaParaFF043(
                    protcolo: prm.Protocolo,
                    appDbContext: prm.InAppDbContext,
                    generateId: prm.InGenerateId,
                    aux_condicaoPagtoDividida: string.Join(";", prm.InNumeroDeParcelas, 0, 30).Split(';'),
                    work_valor_entrada: prm.InValorEntrada
                );
            }

            //a vista
            else if (IsTipoAVista(prm.InTipoBB008_ID_Recuperada, prm.In_StID_bb008_tp_A_vista))
            {
                return new ProcessarParcelasTipoAVistaParaFF043(prm.Protocolo, prm.InAppDbContext, prm.InGenerateId);
            }
            throw new NotSupportedException("Tipo de renegociação não suportado.");
        }



    private static bool IsTipoAVista(int InBB008Tp_ID, int InBB008TpAVista_ID)
    {
        return InBB008Tp_ID == InBB008TpAVista_ID;
    }

    private static bool IsTipoParcelaMes(int InBB008Tp_ID, int InBB008TpMes_ID)
    {
        return InBB008TpMes_ID == InBB008Tp_ID;
    }


    private static bool IsTipoDias(int InBB008Tp_ID, int InBB008TpDias_ID)
    {
        return InBB008Tp_ID == InBB008TpDias_ID;
    }

    private static bool IsTipoParcelaDias(int InBB008Tp_ID, int InBB008TpParcelaDias_ID)
    {
        return InBB008TpParcelaDias_ID == InBB008Tp_ID;
    }


}
