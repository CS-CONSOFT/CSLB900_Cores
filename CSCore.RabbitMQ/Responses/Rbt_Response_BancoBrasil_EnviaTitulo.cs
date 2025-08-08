namespace CSCore.RabbitMQ.Responses
{
    public class Rbt_Response_BancoBrasil_EnviaTitulo
    {
        public string CorrelationID { get; set; }
        public string Resultado { get; set; }
        public bool IsError { get; set; }
    }
}
