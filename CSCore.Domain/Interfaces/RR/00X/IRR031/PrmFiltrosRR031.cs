
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.RR._00X.IRR031
{
    public class PrmFiltrosRR031 : ParametrosBaseFiltro
    {
        public string? In_IATFRR030ID { get; set; }
        public string? In_AnimalID { get; set; }
        public DateTime? In_DtRegistro { get; set; }
        public bool? In_IsPositivo { get; set; }
    }
}