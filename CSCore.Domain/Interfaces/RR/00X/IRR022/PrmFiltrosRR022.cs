
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.RR._00X.IRR022
{
    public class PrmFiltrosRR022 : ParametrosBaseFiltro
    {
        public string? In_LoteId { get; set; }
        public DateTime? In_DataPeso { get; set; }
        public string? In_UsuarioId { get; set; }
    }
}