using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF018
{
    public class DtoCreateUpdateFF018 : IConverteParaEntidade<CSICP_FF018>
    {
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

        public CSICP_FF018 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF018
            {
                TenantId = tenant,
                Id = id!,
                Ff017Id = Ff017Id,
                Ff102Tituloid = Ff102Tituloid,
                Ff018ValorTitulo = Ff018ValorTitulo,
                Ff018ValorMulta = Ff018ValorMulta,
                Ff018ValorJuros = Ff018ValorJuros,
                Ff018ValorDescontos = Ff018ValorDescontos,
                Ff018ValorAberto = Ff018ValorAberto,
                Ff018Situacaotituloid = Ff018Situacaotituloid,
                Ff018Filial = Ff018Filial,
                Ff018FilialTit = Ff018FilialTit,
                Ff018Pfx = Ff018Pfx,
                Ff018Titulo = Ff018Titulo,
                Ff018Sfx = Ff018Sfx,
                Ff018Situacao = Ff018Situacao,
                Ff018Protocolnumber = Ff018Protocolnumber,
                Ff018Vmultaorig = Ff018Vmultaorig,
                Ff018Vjurosorig = Ff018Vjurosorig,
                Ff018Vabertoorig = Ff018Vabertoorig
                };
        }
    }
}
