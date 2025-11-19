using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.RabbitMQ.PublishObjetos.Financeiro.Processos.AgendaCobranca
{
    public class Rbt_CS_PrevisaoGeral
    {
        public int InTenantID { get; set; }
        public string Bb012ID { get; set; } = string.Empty;
        public string? Bb006Id { get; set; } = string.Empty;
        public string Sy001ID { get; set; } = string.Empty;
        public string Mensagem { get; set; } = string.Empty;
        public DateTime DtPrevisao { get; set; }
        public DateTime DtVisita { get; set; }
        public string FF002_Motivo { get; set; } = string.Empty;
        public string BB001_ID { get; set; } = string.Empty;
        public string UsuarioLogadoID { get; set; } = string.Empty;
    }
    
}
