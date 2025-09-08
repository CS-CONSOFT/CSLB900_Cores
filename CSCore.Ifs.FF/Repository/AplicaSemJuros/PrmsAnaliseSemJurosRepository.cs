using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.AplicaSemJuros
{
    public class PrmsAnaliseSemJurosRepository
    {
        public int InTenantID { get; set; }
        public string InFilialID { get; set; } = string.Empty;
        public string InFF102TituloID { get; set; } = string.Empty;
        public string InUsuarioPropID { get; set; } = string.Empty;
        public string InMsgMotivo { get; set; } = string.Empty;
        public int InStIDNCobraJuros { get; set; }
        public int InStIDAtrJurosNCobra { get; set; }
        public int InStIDFF102SitAberto { get; set; }
        public int InStIDFF102SitBxParcial { get; set; }
    }
}
