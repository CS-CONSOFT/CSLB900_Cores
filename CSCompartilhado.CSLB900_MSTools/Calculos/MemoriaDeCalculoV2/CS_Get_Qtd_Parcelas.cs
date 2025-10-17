using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSTools.Calculos.MemoriaDeCalculoV2
{
    public record CS_Get_Qtd_ParcelasParameters(
        int InStID_BB008_TP_DIAS,
        int InStID_BB008_ParcelaDias,
        int InStID_BB008_ParcelaMes,
        int InStID_BB008_AVista
        );

    public record CS_Get_Qtd_ParcelasResult(
        int Qtd_Parcelas,
        int Entrada);
    public static class CS_Get_Qtd_Parcelas
    {
        public static CS_Get_Qtd_ParcelasResult Executar(
            string condicaoPagamento,
            int BB008_Tipo_ID,
            CS_Get_Qtd_ParcelasParameters prm)
        {
            var condicaoPagtoDividida = condicaoPagamento.Split(';');

            if(BB008_Tipo_ID == prm.InStID_BB008_TP_DIAS)
            {
                return new CS_Get_Qtd_ParcelasResult(
                    Qtd_Parcelas: condicaoPagtoDividida.Length,
                    Entrada: 0);
            }

            if(BB008_Tipo_ID == prm.InStID_BB008_ParcelaMes || BB008_Tipo_ID == prm.InStID_BB008_ParcelaDias)
            {
                return new CS_Get_Qtd_ParcelasResult(
                    Qtd_Parcelas: int.Parse(condicaoPagtoDividida[0]),
                    Entrada: int.Parse(condicaoPagtoDividida[1]));
            }
                

            return new CS_Get_Qtd_ParcelasResult(
                Qtd_Parcelas: 1,
                Entrada: 0);
        }
    }
}
