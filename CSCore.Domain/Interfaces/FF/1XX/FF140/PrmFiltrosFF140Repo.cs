using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.FF._1XX.FF140
{
    public class PrmFiltrosFF140Repo : ParametrosBaseFiltro
    {
        public string? InEstabID { get; set; }
        public DateTime? InDataInicio { get; set; }
        public DateTime? InDataFinal { get; set; }
        public string? InContaID { get; set; }
        public string? InProtocoloNumber { get; set; }
        public int? InStatusID { get; set; }

    }
}
