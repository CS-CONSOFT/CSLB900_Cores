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
        public string InIdCG006ContaSuperior { get; private set; } = "";
        public string InTipoSaldoID { get; private set; } = "";
        public int InAno { get; private set; }
        public int InMes { get; private set; }
        public decimal InValorLancamento { get; private set; }
        public int Tenant { get; private set; }
        public string UsuarioID { get; private set; } = "";
        public int InStID_CG993_DebitoCredito { get; private set; }

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
