namespace CSCore.RabbitMQ.PublishObjetos.Financeiro.CG
{
    public class Rbt_CS_PR119_120_AtualizaSaldoMensalContabil
    {
        public string InIdCG006ContaSuperior { get; set; } = "";
        public string InTipoSaldoID { get; set; } = "";
        public int InAno { get; set; }
        public int? InMes { get; set; }
        public DateTime? InDia { get; set; }
        public decimal InValorLancamento { get; set; }
        public int Tenant { get; set; }
        public string UsuarioID { get; set; } = "";
        public int InStID_CG993_DebitoCredito { get; set; }


        public void PreencherDadosAtualizaSaldoMensalContabil(int tenantId,
            int InStID_CG993_DebitoCredito,string InIdCG006ContaSuperior, string InTipoSaldoID,
            int InAno, int? InMes, decimal ValorLancament, string UsuarioID, DateTime? Dia)
        {
           this.Tenant = tenantId;
              this.InIdCG006ContaSuperior = InIdCG006ContaSuperior;
                this.InTipoSaldoID = InTipoSaldoID;
                this.InAno = InAno;
                this.InMes = InMes;
            this.InDia = Dia;
            this.InValorLancamento = ValorLancament;
            this.UsuarioID = UsuarioID;
            this.InStID_CG993_DebitoCredito = InStID_CG993_DebitoCredito;

        }
    }
}
