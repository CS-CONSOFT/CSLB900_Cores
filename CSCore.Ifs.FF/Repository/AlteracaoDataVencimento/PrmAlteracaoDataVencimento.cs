namespace CSCore.Ifs.FF.Repository.AlteracaoDataVencimento
{
    public class PrmAlteracaoDataVencimento
    {
        public int InTenantID { get; set; }
        public string InFF102ID { get; set; } = string.Empty;
        public int InTipoRegistro { get; set; }
        public string InUsuarioID { get; set; } = string.Empty;
        public string InFilialIDBB001 { get; set; } = string.Empty;
        public DateTime InNovaDataVencimento { get; set; }
        public string InMotivo { get; set; } = string.Empty;
        public int InStIDFF102SitAberto { get; set; }
        public int InStIDAlteracaoDataVencimento { get; set; }
    }
}