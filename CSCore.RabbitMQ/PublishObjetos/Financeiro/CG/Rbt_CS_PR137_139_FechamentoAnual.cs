using CSCore.RabbitMQ.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.RabbitMQ.PublishObjetos.Financeiro.CG
{
    public class Rbt_CS_PR137_139_FechamentoAnual : IConsumerUsuarioId, ITenantId
    {
        public string UsuarioID { get; set; } = string.Empty;

        public int InTenantID { get; set; }

        public int InAnoFechamento { get; set; }
        public int InAnoNovo { get; set; }
        public string InTipoSaldo { get; set; } = string.Empty;
        public string InFilialID { get; set; } = string.Empty;
    }
}
