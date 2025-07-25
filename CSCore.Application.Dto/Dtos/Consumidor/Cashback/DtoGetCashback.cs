namespace CSCore.Application.Dto.Dtos.Consumidor.Cashback
{
    public class DtoGetCashback
    {
        public DateTime? dtRegistro { get; set; } = default;
        public DateTime? dhRegistro { get; set; } = default;
        public DateTime? Data_Liberacao { get; set; } = default;
        public decimal? vCashback { get; set; } = default;
        public string? Status { get; set; } = string.Empty;
        public string? Nota { get; set; } = string.Empty;
        public string? Serie { get; set; } = string.Empty;

        public DtoGetCashback(DateTime? dtRegistro, DateTime? dhRegistro, DateTime? data_Liberacao,
            decimal? vCashback, string? status, string? nota, string? serie)
        {
            this.dtRegistro = dtRegistro;
            this.dhRegistro = dhRegistro;
            Data_Liberacao = data_Liberacao;
            this.vCashback = vCashback;
            Status = status;
            Nota = nota;
            Serie = serie;
        }
    }
}
