using CSLB900.MSTools.CS_QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.PrmFiltros.FF125
{
    public class PrmFiltrosFF125 : ParametrosBaseFiltro
    {
        public int? InBB012_SitCtaId { get; set; }
        public string? InBB010_ZonaCobrancaId { get; set; }
        public string? InBB006_CobradorID { get; set; }
        public DateTime? InDataRegistroInicial { get; set; }
        public DateTime? InDataRegistroFinal { get; set; }
        public DateTime? InDataPrevisaoInicial { get; set; }
        public DateTime? InDataPrevisaoFinal { get; set; }
        public string? InNomeCliente { get; set; }
        public EnumRegistroCobradoFF125? InRegistroCobrado { get; set; }
    }

    public enum EnumRegistroCobradoFF125
    {
        NaoCobrado = 1,
        Cobrado = 2,
        Nenhum = 0
    }
}
