using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.RR._00X.IRR020
{
    public class PrmFiltrosRR020 : ParametrosBaseFiltro
    {
        public string? In_Identificador { get; set; }
        public string? In_Descricao { get; set; }
    }
}