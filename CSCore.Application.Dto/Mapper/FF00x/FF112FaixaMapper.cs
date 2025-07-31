using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF112;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF112Faixa;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF112;

namespace CSCore.Application.Dto.Mapper.FF00x
{
    public static class FF112FaixaMapper
    {
        public static DtoGetFF112Faixa ToDtoGetFF112Faixa(this CSICP_FF112Faixa entity)
        {
            return new DtoGetFF112Faixa
            {
                TenantId = entity.TenantId,
                Ff112FaixaId = entity.Ff112FaixaId,
                Ff112Id = entity.Ff112Id,
                Ff112NossonroInicial = entity.Ff112NossonroInicial,
                Ff112NossonroFinal = entity.Ff112NossonroFinal,
                Ff112NossonroAtual = entity.Ff112NossonroAtual,
                Ff112Avisonossonro = entity.Ff112Avisonossonro,
                Ff112Isactive = entity.Ff112Isactive
            };
        }
    }
}
