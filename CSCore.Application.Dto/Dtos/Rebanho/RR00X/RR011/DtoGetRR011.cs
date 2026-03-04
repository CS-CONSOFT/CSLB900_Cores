namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR011
{
    /// <summary>
    /// DTO para retorno completo de Série/RGN (RR011)
    /// </summary>
    public class DtoGetRR011
    {
        public int TenantId { get; set; }
        
        public long Id { get; set; }
        
        public string Rr011Serie { get; set; } = null!;
        
        public int Rr011Ultrgn { get; set; }
    }
}