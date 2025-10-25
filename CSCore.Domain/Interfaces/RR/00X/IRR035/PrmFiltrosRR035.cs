
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.RR._00X.IRR035
{
    public class PrmFiltrosRR035 : ParametrosBaseFiltro
    {
        public string? In_Descricao { get; set; }
        public string? In_NroSemen { get; set; }
        public string? In_Lote { get; set; }
        public long? In_RacaID { get; set; }
    }
}