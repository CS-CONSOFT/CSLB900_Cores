using CSLB900.MSTools.CS_QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.Domain.Interfaces.RR._00X.IRR009
{
    public class PrmFiltrosRR009 : ParametrosBaseFiltro
    {
        /// <summary>
        /// Filtro por ID do Animal Real
        /// </summary>
        public string? Rr001Id { get; set; }

        /// <summary>
        /// Filtro por ID do Animal Virtual
        /// </summary>
        public string? Rr001Virtualid { get; set; }
    }
}
