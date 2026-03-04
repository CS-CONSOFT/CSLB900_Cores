using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.RR._00X.IRR011
{
    /// <summary>
    /// Parâmetros de filtro para consulta de Séries/RGN (RR011)
    /// </summary>
    public class PrmFiltrosRR011 : ParametrosBaseFiltro
    {
        /// <summary>
        /// Filtro por Série (busca parcial)
        /// </summary>
        public string? Rr011Serie { get; set; }

        /// <summary>
        /// Filtro por Último RGN (busca exata)
        /// </summary>
        public int? Rr011Ultrgn { get; set; }
    }
}