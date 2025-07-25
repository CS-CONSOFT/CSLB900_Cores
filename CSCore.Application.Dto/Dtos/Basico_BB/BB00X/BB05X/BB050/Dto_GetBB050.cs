namespace CSBS101._82Application.Dto.BB00X.BB05X.BB050
{
    public class Dto_GetBB050
    {
        public int TenantId { get; set; }

        public string Bb050Id { get; set; } = null!;

        public string? Bb050Empresaid { get; set; }

        public string? Bb050Grupoprodutoid { get; set; }

        public DateTime? Bb050Datainicio { get; set; }

        public DateTime? Bb050Datafinal { get; set; }

        public decimal? Bb050Valorminimo { get; set; }
    }
}
