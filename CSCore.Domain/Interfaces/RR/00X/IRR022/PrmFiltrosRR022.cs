
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.RR._00X.IRR022
{
    public class PrmFiltrosRR022 : ParametrosBaseFiltro
    {
        public string? In_AnimalId { get; set; }
        public decimal? In_PesoMinimo { get; set; }
        public decimal? In_PesoMaximo { get; set; }
    }
}