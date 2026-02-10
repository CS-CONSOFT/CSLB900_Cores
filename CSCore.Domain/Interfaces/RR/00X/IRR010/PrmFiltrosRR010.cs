using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.RR._00X.IRR010
{
    /// <summary>
    /// Parâmetros de filtro para consulta de Condições de Criação (RR010)
    /// </summary>
    public class PrmFiltrosRR010 : ParametrosBaseFiltro
    {
        /// <summary>
        /// Filtro por Condição de Criação (busca parcial)
        /// </summary>
        public string? Rr010Condcriacao { get; set; }

        /// <summary>
        /// Filtro por Descritivo (busca parcial)
        /// </summary>
        public string? Rr010Descritivo { get; set; }
    }
}