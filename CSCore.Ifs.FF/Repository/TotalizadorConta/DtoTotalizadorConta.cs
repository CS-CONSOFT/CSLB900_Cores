using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.TotalizadorConta
{
    public class DtoTotalizadorConta
    {
        public decimal Vl_Liq_TituloSum { get; set; }
        public int MaiorAtrasoMax { get; set; }
        public int Qtde_Atraso { get; set; }
    }
}
