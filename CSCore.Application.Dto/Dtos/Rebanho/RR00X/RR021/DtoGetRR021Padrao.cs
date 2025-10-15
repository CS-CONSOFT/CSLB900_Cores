namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR021
{
    public class DtoGetRR021Padrao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Rr021Loteid { get; set; }

        public string? Rr021Animalid { get; set; }

        public DateTime? Rr021Dtregistro { get; set; }
    }
}