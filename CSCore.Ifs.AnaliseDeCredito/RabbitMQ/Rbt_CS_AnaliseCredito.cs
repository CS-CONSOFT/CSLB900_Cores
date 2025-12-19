namespace CSCore.Ifs.AnaliseDeCredito.RabbitMQ
{
    public class Rbt_CS_AnaliseCredito
    {
        public int in_tenantID { get; set; }
        public string in_conta_ID { get; set; } = string.Empty;
        public string in_usuarioID { get; set; } = string.Empty;
        public bool in_CalcularScoreClearsale { get; set; }
    }
}
