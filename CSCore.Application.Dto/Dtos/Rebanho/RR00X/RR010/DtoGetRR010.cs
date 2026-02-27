namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR010
{
    /// <summary>
    /// DTO para retorno completo de Condição de Criação (RR010)
    /// </summary>
    public class DtoGetRR010
    {
        public int TenantId { get; set; }
        
        public long Id { get; set; }

        public string Rr010Condcriacao { get; set; } = string.Empty;

        public string Rr010Descritivo { get; set; } = string.Empty;
    }
}