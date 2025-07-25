namespace CSCore.Domain.CS_QueryFilters.Consumidor
{
    public class FiltroTitulosCRParametros
    {
        public bool? TitAbertos { get; set; } = default;
        public bool? TitRenegociados { get; set; } = default;
        public bool? TitGerais { get; set; } = default;
        public string? Data_referencia { get; set; } = default;
        public int? TP_Filtro { get; set; } = default;
        public string? Prefixo { get; set; } = default;
        public int? NrTitulo { get; set; } = default;
        public string? Sufixo { get; set; } = default;
        public double? Juros_Dias { get; set; } = default;
        public DateTime? dt_inicial { get; set; } = default;
        public DateTime? dt_final { get; set; } = default;
        public int? TitSituacaoID { get; set; } = default;
    }
}
