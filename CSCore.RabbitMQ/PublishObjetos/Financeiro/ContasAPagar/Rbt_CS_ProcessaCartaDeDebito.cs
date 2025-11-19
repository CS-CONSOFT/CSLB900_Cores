using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.RabbitMQ.PublishObjetos.Financeiro.ContasAPagar
{
    public class Rbt_CS_ProcessaCartaDeDebito
    {
        public CSICP_FF136 CSICP_FF136 { get; set; } = null!;
        public string UsuarioID { get; set; } = string.Empty;
    }
}
