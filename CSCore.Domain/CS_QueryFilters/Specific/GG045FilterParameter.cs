using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.CS_QueryFilters.Specific
{
    public class GG045FilterParameter : ParametrosBaseFiltro
    {
        public string? SearchDescricao { get; set; }
        public string? VSerieNF { get; set; }
        public string? VNumNF {get;set;}
        public DateTime DataInicial {get;set;}
        public DateTime DataFinal { get; set; }
    }
}
