using CSCore.RabbitMQ.Configuration;
using System.Text.Json.Serialization;

namespace CSCore.RabbitMQ.PublishObjetos.Rebanho
{
    public class Rbt_CS_ProcessaRegistroPesoAnimal : IConsumerUsuarioId
    {
        /// <summary>
        /// ID do Tenant
        /// </summary>
        [JsonIgnore]
        public int TenantID { get; set; }

        /// <summary>
        /// ID do Lote (RR022)
        /// </summary>
        public string LoteId { get; set; } = string.Empty;

        /// <summary>
        /// Data do Peso
        /// </summary>
        public DateTime DataPeso { get; set; }

        /// <summary>
        /// ID do usuário que iniciou o processamento
        /// </summary>
        public string UsuarioID { get; set; } = string.Empty;
    }
}