using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.EntityFramework.Extensions;

namespace CSCore.RabbitMQ.PublishObjetos.Financeiro.CG
{
    public class Rbt_CS_PR119_AtualizaSaldoMensalContabil
    {
        public string InIdCG006ContaSuperior { get; set; } = "";
        public string InTipoSaldoID { get; set; } = "";
        public int InAno { get; set; }
        public int InMes { get; set; }
        public decimal InValorLancamento { get; set; }
        public int Tenant { get; set; }
        public string UsuarioID { get; set; } = "";
        public int InStID_CG993_DebitoCredito { get; set; }

        public void Popular(int tenantId, int InStID_CG993_DebitoCredito,string InIdCG006ContaSuperior, string InTipoSaldoID, int InAno, int InMes, decimal ValorLancament, string UsuarioID)
        {
           this.Tenant = tenantId;
              this.InIdCG006ContaSuperior = InIdCG006ContaSuperior;
                this.InTipoSaldoID = InTipoSaldoID;
                this.InAno = InAno;
                this.InMes = InMes;
            this.InValorLancamento = ValorLancament;
            this.UsuarioID = UsuarioID;
            this.InStID_CG993_DebitoCredito = InStID_CG993_DebitoCredito;

        }
    }
}
