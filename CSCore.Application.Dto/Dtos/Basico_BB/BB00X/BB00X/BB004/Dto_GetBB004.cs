namespace CSBS101._82Application.Dto.BB00X.BB004
{
    public class Dto_GetBB004
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb004Codigo { get; set; }

        public DateTime? Bb004Datacambio { get; set; }

        public decimal? Bb004Valorcambio { get; set; }

        public string? Moedaid { get; set; }
    }
}
