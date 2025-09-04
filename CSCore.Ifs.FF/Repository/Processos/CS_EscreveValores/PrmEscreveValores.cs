using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_EscreveValores
{
    public class PrmEscreveValores
    {
        public int InTenantID { get; set; }
        public int InSTIDFF102SitAberto { get; set; }
        public int InSTID102BxParcial { get; set; }
        public string InFF017ID { get; set; } = string.Empty;
    }
}
