using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.CS_QueryFilters.Specific
{
    public class GG071FilterParameters : ParametrosBaseFiltro
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public string? Protocolo { get; set; }
        public string? BB005_CentroDeCusto_ID { get; set; }
        public int? GG071_Status_ID { get; set; }
        public int? GG041_TpReq_ID { get; set; }
        public string? SY001_UsuarioID { get; set; }
        public string? BB001_EstabID { get; set; }
    }
}
