using CSLB900.MSTools.CS_QueryFilters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX.FF127
{
    public class PrmFiltrosFF127Repo : ParametrosBaseFiltro
    {
        [Required]
        public string InBB012_ContaID { get; set; } = string.Empty;
        public string? InCobradorID_BB006 { get; set; } = string.Empty;
    }
}
