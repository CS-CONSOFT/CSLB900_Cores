namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_GetAA040
    {
        public int TenantId { get; set; }

        public string Aa040Id { get; set; } = null!;

        public string? Aa040UforigemId { get; set; }

        public string? Aa040UfdestinoId { get; set; }

        public decimal? Aa040Paliquota { get; set; }
    }
}
