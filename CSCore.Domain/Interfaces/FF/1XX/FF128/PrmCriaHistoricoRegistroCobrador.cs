namespace CSCore.Ifs.FF.Repository.FF1XX.FF128
{
    public class PrmCriaHistoricoRegistroCobrador
    {
        public string InNovoId { get; set; } = null!;
        public string InFF102TituloId { get; set; } = string.Empty;
        public DateTime? InDataPrevisao { get; set; }
        public DateTime? InDataLimitePrevisao { get; set; }
        public string InFF128Mensagem { get; set; } = string.Empty;
        public string InFF127Id { get; set; } = string.Empty;
        public int? InDiasAtrasoEnt { get; set; }
        public int? InSitCobrancaEntId { get; set; }
        public int? InSituacaoSaiId { get; set; }
        public string InCobradorId { get; set; } = string.Empty;
    }
}
