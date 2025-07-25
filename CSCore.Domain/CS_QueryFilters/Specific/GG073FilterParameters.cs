using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.CS_QueryFilters.Specific
{
    public class GG073FilterParameters : ParametrosBaseFiltro
    {
        public string? Protocolo { get; set; }
        public string? BB001_EstabID { get; set; } = null;
        /// <summary>
        /// Obrigatorio
        /// </summary>
        public DateTime DataInicial { get; set; }
        /// <summary>
        /// Obrigatorio
        /// </summary>
        public DateTime DataFinal { get; set; }
        public string? BB005_CentroCustoID { get; set; }
        public string? GG001_AlmoxID { get; set; }
        public int? GG073_StatusID { get; set; }
        public int? GG073_TMov_ID { get; set; }
    }
}
