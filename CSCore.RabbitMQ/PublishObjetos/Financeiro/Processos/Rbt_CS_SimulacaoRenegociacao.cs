using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.RabbitMQ.PublishObjetos.Financeiro.Processos
{
    public class Rbt_CS_SimulacaoRenegociacao
    {
        public string in_renegociacaoID { get; set; } = string.Empty;
        public string in_condicaoPagamento { get; set; } = string.Empty;
        public decimal in_valorEntrada { get; set; }
        public DateTime in_data { get; set; }
        public int tenant { get; set; }
        public string usuarioID { get; set; }
    }
}
