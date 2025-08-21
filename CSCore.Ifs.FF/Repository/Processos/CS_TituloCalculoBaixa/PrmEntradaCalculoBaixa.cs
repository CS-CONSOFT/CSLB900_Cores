using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_TituloCalculoBaixa
{
    public class PrmEntradaCalculoBaixa
    {
        public int InTenantID { get; set; }
        public int InSTIDFF102Liquidado { get; set; }
        public int InSTIDFF102BxParcial { get; set; }
        public int InSTIDFF102Aberto { get; set; }
        public int InSTIDFF103TpBaiCancelamento { get; set; }
        public int InSTIDFF103TpBaiDevolucao { get; set; }
        public int InSTIDFF103TpBaiDoacao { get; set; }
        public string InFF102Id { get; set; } = string.Empty;
        public string InBB001Id { get; set; } = string.Empty;
    }
}
