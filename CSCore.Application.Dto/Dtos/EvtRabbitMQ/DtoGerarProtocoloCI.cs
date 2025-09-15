namespace CSCore.Application.Dto.Dtos.EvtRabbitMQ
{
    public class DtoGerarProtocoloCI
    {
        public string EmpresaID { get; set; } = string.Empty;
        public string TextName { get; set; } = string.Empty;
        public string Arquivo { get; set; } = string.Empty;
        public string InUsuarioID { get; set; } = string.Empty;
        public int InTenantID { get; set; } = 0;
    }
}
