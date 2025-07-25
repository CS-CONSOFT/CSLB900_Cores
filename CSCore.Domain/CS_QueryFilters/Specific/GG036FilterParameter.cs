using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.CS_QueryFilters.Specific
{
    public class GG036FilterParameter : ParametrosBaseFiltro
    {
        public string IDEstabelecimento { get; set; }
        public string IDProduto { get; set; }
        public string IDGrupo { get; set; }
        public DateTime? data { get; set; }  = default(DateTime?);
    }
}
