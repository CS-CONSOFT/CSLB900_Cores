using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF018
{
    public class DtoGetFF018
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Ff017Id { get; set; }

        public string? Ff102Tituloid { get; set; }

        public decimal? Ff018ValorTitulo { get; set; }

        public decimal? Ff018ValorMulta { get; set; }

        public decimal? Ff018ValorJuros { get; set; }

        public decimal? Ff018ValorDescontos { get; set; }

        public decimal? Ff018ValorAberto { get; set; }

        public int? Ff018Situacaotituloid { get; set; }

        public int? Ff018Filial { get; set; }

        public int? Ff018FilialTit { get; set; }

        public string? Ff018Pfx { get; set; }

        public decimal? Ff018Titulo { get; set; }

        public string? Ff018Sfx { get; set; }

        public string? Ff018Situacao { get; set; }

        public string? Ff018Protocolnumber { get; set; }

        public decimal? Ff018Vmultaorig { get; set; }

        public decimal? Ff018Vjurosorig { get; set; }

        public decimal? Ff018Vabertoorig { get; set; }

        public DtoGetFF102_SemNavs? NavFF102 { get; set; }

        public CSICP_FF102Sit? NavFF102Sit { get; set; }
    }
}
