using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.AlteracaoDataVencimento
{
    public class PrmsAlteracaoDataVencimentoRepository
    {
        public int InTenantID { get; set; }
        public string InFilialID { get; set; } = string.Empty;
        public string InFF102TituloID { get; set; } = string.Empty;
        public string InUsuarioPropID { get; set; } = string.Empty;
        public DateTime InNovaDataVencimento { get; set; }
        public int InStIDProrrogar { get; set; }
        public int InStIDFF102SitAberto { get; set; }
    }
}
