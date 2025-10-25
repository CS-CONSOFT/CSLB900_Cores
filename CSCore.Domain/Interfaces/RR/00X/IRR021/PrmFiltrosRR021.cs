
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.RR._00X.IRR021
{
    public class PrmFiltrosRR021 : ParametrosBaseFiltro
    {
        public string? In_AnimalId { get; set; }
        public DateTime? In_DtRegistroInicio { get; set; }
        public DateTime? In_DtRegistroFim { get; set; }
    }
}