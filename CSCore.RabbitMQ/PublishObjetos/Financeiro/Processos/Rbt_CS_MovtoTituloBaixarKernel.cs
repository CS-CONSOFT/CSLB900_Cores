using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.RabbitMQ.PublishObjetos.Financeiro.Processos
{
    public class Rbt_CS_MovtoTituloBaixarKernel
    {
        public string InFF103ID { get; set; } = string.Empty;
        public string InSY001UsuarioID { get; set; } = string.Empty;
        public string InEstabID_tituloCalcBaixa { get; set; } = string.Empty;
        public int InTenantID { get; set; } = 0;
    }
}
