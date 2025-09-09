using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF125.ContadorCobrancaConsulta
{
    public class RepoDtoContadorCobrancaConsulta
    {
        public int TenantID { get; set; }
        public string NomeTabela { get; set; } = string.Empty;
        public int Contador { get; set; }
    }


}
