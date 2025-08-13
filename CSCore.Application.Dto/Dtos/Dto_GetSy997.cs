namespace CSSY103.C82Application.Dto.SY997
{
    public class Dto_GetSy997
    {
        public int TenantId { get; set; }
        public long Id { get; set; }
        public string? Sy997ExternalId { get; set; }
        public DateTime? Sy997Datainc { get; set; }
        public string? Sy997Nomeusuario { get; set; }
        public string? Sy997Mensagem { get; set; }
        public bool? Sy997Isexibiu { get; set; }
        public string? Sy997Severidade { get; set; }
    }
}