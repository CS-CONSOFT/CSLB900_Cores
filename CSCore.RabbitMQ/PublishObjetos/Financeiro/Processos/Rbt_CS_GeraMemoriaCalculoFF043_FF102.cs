using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.RabbitMQ.PublishObjetos.Financeiro.Processos
{
    public record Rbt_CS_GeraMemoriaCalculoFF043_FF102(
            int InTenantID,
            string InEmpresaID,
            long InFF040_ID,
            DateTime InDataBaseVencimento,
            string InFormaPgtoID,
            string InCondicaoPgtoID,
            int InNroDeParcelas,
            decimal InFaturaTotal,
            string InUsuarioID = ""
    );
}
