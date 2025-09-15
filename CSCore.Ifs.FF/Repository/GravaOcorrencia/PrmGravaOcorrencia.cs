namespace CSCore.Ifs.FF.Repository.GravaOcorrencia
{
    public class PrmGravaOcorrencia
    {
        // Propriedades obrigatórias
        public int InTenantID { get; set; }
        public string InFF102TituloID { get; set; } = string.Empty;
        public string InUsuarioPropID { get; set; } = string.Empty;
        public string? InFilialID { get; set; }
        public DateTime? InDataVencimento { get; set; }
        public DateTime? InNovaDataVencimento { get; set; }
        public int? InTipoMovimento { get; set; }
        public string InMsgMotivo { get; set; } = string.Empty;
        public int InStIDNCobraJuros { get; set; }
        public int InStIDFF102SitAberto { get; set; }
        public int InStIDFF102SitBxParcial { get; set; }
    }
}