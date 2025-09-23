using CSCore.Domain.CS_Models.CSICP_FF;
using CSLB900.MSTools.CS_QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040
{
    public class PrmFiltrosFF040Repo : ParametrosBaseFiltro
    {
        public string? InEstabID { get; set; }
        public string InNomeContaID { get; set; } //perguntar ao Valter sobre esse campo
        public string? InProtocoloNumber { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string? InTipoCobrancaID { get; set; }
        public int? InStatusID { get; set; }
        }
}