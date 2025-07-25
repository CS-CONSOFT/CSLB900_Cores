namespace CSBS101._82Application.Dto.BB00X.BB021
{
    public class Dto_GetBB021
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb021Filial { get; set; }

        public DateTime? Bb021DataEmissao { get; set; }

        public decimal? Bb021Autorizacao { get; set; }

        public DateTime? Bb021Hora { get; set; }

        public int? Bb021Codautorizador { get; set; }

        public string? Bb021NomeAutorizador { get; set; }

        public string? Bb021Situacao { get; set; }

        public string? Bb021Modulo { get; set; }

        public int? Bb021Tipo { get; set; }

        public decimal? Bb021PercentualValor { get; set; }

        public int? Bb021Codautorizado { get; set; }

        public string? Bb021NomeAutorizado { get; set; }

        public int? Bb021CodigoProduto { get; set; }
    }
}
