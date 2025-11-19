using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.RabbitMQ.PublishObjetos.Financeiro.RequisicaoDespesa
{
    public record Rbt_CS_PR34_GerarContasAPagar
   (
       int in_tenant,
       DateOnly Prm_1o_Vencto,
       long ff140ID,
       string usuarioID,
       string InEMPRESA_ID,
       int InNumeroParcelas = 0,
       decimal? Prm_Total_Fatura = 0,
       decimal? Prm_Valor_Entrada = 0
   );
}
