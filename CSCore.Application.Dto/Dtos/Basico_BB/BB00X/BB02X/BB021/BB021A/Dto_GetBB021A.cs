namespace CSBS101._82Application.Dto.BB00X
{
    public class Dto_GetBB021A
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb021aFilial { get; set; }

        public decimal? Bb021aCiOrigem { get; set; }

        public int? Bb021aCiOrigemSeq { get; set; }

        public int? Bb021aNoestacao { get; set; }

        public string? Bb021aTabela { get; set; }

        public decimal? Bb021aNoautorizacao { get; set; }

        public DateTime? Bb021aDataemissao { get; set; }
    }
}
