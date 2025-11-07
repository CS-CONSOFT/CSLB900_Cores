using CSCore.RabbitMQ.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSCore.RabbitMQ.PublishObjetos.Rebanho
{
    public class Rbt_CS_ProcessaLoteAtualizaPeso : IConsumerUsuarioId
    {
        /// <summary>
        /// ID do Tenant
        /// </summary>
        [JsonIgnore]
        public int TenantID { get; set; }

        /// <summary>
        /// ID do Lote (RR020)
        /// </summary>
        public string RR020IDLote { get; set; } = string.Empty;

        /// <summary>
        /// ID do usuário que iniciou o processamento
        /// </summary>
        public string UsuarioID { get; set; } = string.Empty;
    }
}
