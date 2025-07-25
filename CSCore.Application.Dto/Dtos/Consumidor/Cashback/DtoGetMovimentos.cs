namespace CSCore.Application.Dto.Dtos.Consumidor.Cashback
{
    public class DtoGetMovimentos
    {
        public string? Protocolo { get; set; } = string.Empty;
        public DateTime? DtHrMovimento { get; set; } = default;
        public decimal? ValorMovimento { get; set; } = default;
        public string? Historico { get; set; } = string.Empty;
        public int? TpMovimento { get; set; } = default;
        public string? TpMovimentoLabel { get; set; } = string.Empty;

        public DtoGetMovimentos(string? protocolo, DateTime? dtHrMovimento, decimal? valorMovimento,
            string? historico, int? tpMovimento, string? tpMovimentoLabel)
        {
            Protocolo = protocolo;
            DtHrMovimento = dtHrMovimento;
            ValorMovimento = valorMovimento;
            Historico = historico;
            TpMovimento = tpMovimento;
            TpMovimentoLabel = tpMovimentoLabel;
        }
    }
}
