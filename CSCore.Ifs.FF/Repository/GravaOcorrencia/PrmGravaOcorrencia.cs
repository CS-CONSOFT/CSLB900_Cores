namespace CSCore.Ifs.FF.Repository.GravaOcorrencia
{
    public class PrmGravaOcorrencia
    {
        // Propriedades obrigatórias
        public int InTenantID { get; set; }
        public string InFF102ID { get; set; } = string.Empty;
        public string InUsuarioID { get; set; } = string.Empty;
        
        // Propriedades específicas por contexto
        public string? InFilialIDBB001 { get; set; }
        public int? TipoMovimento { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? NovaDataVencimento { get; set; }
        public decimal? ValorAntigo { get; set; }
        public decimal? ValorNovo { get; set; }
        public string? Motivo { get; set; }
        
        // Propriedades específicas para validações (vindas das classes originais)
        public int? InTipoRegistro { get; set; }
        public int? InStIDFF102SitAberto { get; set; }
        public int? InStIDFF102SitBxParcial { get; set; }
        public int? InStIDNCobraJuros { get; set; }
        public int? InStIDProrrogar { get; set; }
        
        // Propriedade para identificar o tipo de operação
        public TipoOperacaoOcorrencia TipoOperacao { get; set; }
    }

    public enum TipoOperacaoOcorrencia
    {
        AlteracaoDataVencimento = 1,
        AplicaSemJuros = 2
    }
}