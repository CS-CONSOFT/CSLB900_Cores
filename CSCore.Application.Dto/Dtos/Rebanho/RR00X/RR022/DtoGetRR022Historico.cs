namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR022
{
    /// <summary>
    /// DTO simplificado para histórico de registros de peso (últimos 5)
    /// </summary>
    public class DtoGetRR022Historico
    {
        public string? Rr022Animalid { get; set; }
        public DateTime? Rr022Dtpeso { get; set; }
        public int? Rr022Idadediasatual { get; set; }
        public decimal? Rr022Peso { get; set; }
        public decimal? Rr022Gmd { get; set; }
        public decimal? Rr022Gpd { get; set; }
        public string? Rr022Observacao { get; set; }
        public decimal? Rr022Circexcrotal { get; set; }
        public long? Rr022Condcriacaid { get; set; }
    }
}