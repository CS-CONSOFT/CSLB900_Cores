using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.CS_QueryFilters.Specific
{
    public class GG054FilterParameter : ParametrosBaseFiltro
    {
        public string? Search { get; set; }
        public string? GG001_ID { get; set; }
        public int? GG054_StatusID { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
    }
}
