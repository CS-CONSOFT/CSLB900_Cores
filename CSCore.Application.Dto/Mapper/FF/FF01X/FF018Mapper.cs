using CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF018;
using CSCore.Application.Dto.Mapper.FF.FF1XX;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF.FF01X
{
    public static class FF018Mapper
    {
        public static DtoGetFF018 ToDtoGet(this CSICP_FF018 entity)
        {
            return new DtoGetFF018
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff017Id = entity.Ff017Id,
                Ff102Tituloid = entity.Ff102Tituloid,
                Ff018ValorTitulo = entity.Ff018ValorTitulo,
                Ff018ValorMulta = entity.Ff018ValorMulta,
                Ff018ValorJuros = entity.Ff018ValorJuros,
                Ff018ValorDescontos = entity.Ff018ValorDescontos,
                Ff018ValorAberto = entity.Ff018ValorAberto,
                Ff018Situacaotituloid = entity.Ff018Situacaotituloid,
                Ff018Filial = entity.Ff018Filial,
                Ff018FilialTit = entity.Ff018FilialTit,
                Ff018Pfx = entity.Ff018Pfx,
                Ff018Titulo = entity.Ff018Titulo,
                Ff018Sfx = entity.Ff018Sfx,
                Ff018Situacao = entity.Ff018Situacao,
                Ff018Protocolnumber = entity.Ff018Protocolnumber,
                Ff018Vmultaorig = entity.Ff018Vmultaorig,
                Ff018Vjurosorig = entity.Ff018Vjurosorig,
                Ff018Vabertoorig = entity.Ff018Vabertoorig,
                NavFF102 = entity.NavFF102?.ToDtoGet_SemNavs(),
                NavFF102Sit = entity.NavFF102Sit
            };
        }
    }
}