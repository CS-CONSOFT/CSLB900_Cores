using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSCore.RabbitMQ.PublishObjetos.Financeiro.Processos
{
    public class Rbt_CS_RenegociacaoCriaTitulos
    {
        public string? InFF017ID { get; set; }
        public string? InSy001ID { get; set; }
        public string InBB001FilialID { get; set; } = null!;
        public bool InEntLiquidada { get; set; }
        [JsonIgnore]
        public int InTenant { get; set; }
    }
}
