namespace CSCore.Ifs.FF.Repository.AplicaSemJuros
{
    public class PrmAplicaSemJuros
    {
        public int InTenantID { get; set; }
        public string InFF102ID { get; set; } = string.Empty;
        public int InTipoRegistro { get; set; }
        public string InUsuarioID { get; set; } = string.Empty;
        public int InStIDFF102SitAberto { get; set; }
        public int InStIDFF102SitBxParcial { get; set; }
        public int InStIDNCobraJuros { get; set; }
        public string InMotivo { get; set; } = string.Empty;
    }
}