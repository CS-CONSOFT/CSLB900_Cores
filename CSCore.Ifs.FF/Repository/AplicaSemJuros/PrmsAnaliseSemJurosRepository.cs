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
        public string InFF102TituloID { get; set; } = string.Empty;
        public string InUsuarioPropID { get; set; } = string.Empty;
    }
}
