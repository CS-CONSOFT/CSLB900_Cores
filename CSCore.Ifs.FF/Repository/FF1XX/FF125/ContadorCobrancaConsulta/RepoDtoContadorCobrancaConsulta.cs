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
        public string Label { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public int Contador { get; set; }
    }

    public class ListRepoDtoContadorCobrancaConsulta
    {
        public IEnumerable<RepoDtoContadorCobrancaConsulta> ListaCountAgCobrador { get; set; } = new List<RepoDtoContadorCobrancaConsulta>();
        public IEnumerable<RepoDtoContadorCobrancaConsulta> ListaCountZona { get; set; } = new List<RepoDtoContadorCobrancaConsulta>();
        public IEnumerable<RepoDtoContadorCobrancaConsulta> ListaCountSitCta { get; set; } = new List<RepoDtoContadorCobrancaConsulta>();
    }


}
