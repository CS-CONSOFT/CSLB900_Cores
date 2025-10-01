using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040
{
    public class PrmFiltrosFF040Repo : ParametrosBaseFiltro
    {
        public string? InEstabID { get; set; }
        public string? InContaID { get; set; } 
        public string? InProtocoloNumber { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int? InTipoRegistro { get; set; }
        public int? InStatusID { get; set; }
        }
}