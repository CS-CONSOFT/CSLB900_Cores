using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF105;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF105Mapper
    {
        public static DtoGetFF105 ToDtoGetFF105(this CSICP_FF105 entity)
        {
            return new DtoGetFF105
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff105Filialid = entity.Ff105Filialid,
                Ff105Descricaobordero = entity.Ff105Descricaobordero,
                Ff105ClienteInicial = entity.Ff105ClienteInicial,
                Ff105ClienteFinal = entity.Ff105ClienteFinal,
                Ff105EmissaoInicial = entity.Ff105EmissaoInicial,
                Ff105EmissaoFinal = entity.Ff105EmissaoFinal,
                Ff105VenctoInicial = entity.Ff105VenctoInicial,
                Ff105VenctoFinal = entity.Ff105VenctoFinal,
                Ff105CodgcategIni = entity.Ff105CodgcategIni,
                Ff105CodgcategFim = entity.Ff105CodgcategFim,
                Ff105CodgrotaIni = entity.Ff105CodgrotaIni,
                Ff105CodgrotaFim = entity.Ff105CodgrotaFim,
                Ff105ValorMinimo = entity.Ff105ValorMinimo,
                Ff105Agcobradorid = entity.Ff105Agcobradorid,
                Ff105Tipocobrancaid = entity.Ff105Tipocobrancaid,
                Ff105InstCobranca1 = entity.Ff105InstCobranca1,
                Ff105InstCobranca2 = entity.Ff105InstCobranca2,
                Ff105Agencia = entity.Ff105Agencia,
                Ff105AgenciaDv = entity.Ff105AgenciaDv,
                Ff105ContaCorrente = entity.Ff105ContaCorrente,
                Ff105ContaDv = entity.Ff105ContaDv,
                Ff105DataEnvio = entity.Ff105DataEnvio,
                Ff105ValorBordero = entity.Ff105ValorBordero,
                Ff105QtdTitulos = entity.Ff105QtdTitulos,
                Ff105Fechado = entity.Ff105Fechado,
                Ff105IsActive = entity.Ff105IsActive,
                Ff105Status = entity.Ff105Status,
                Ff105Protocolnumber = entity.Ff105Protocolnumber,
                Ff105ApiId = entity.Ff105ApiId,
                Ff105Statusapi = entity.Ff105Statusapi,
                Ff105DataCriacao = entity.Ff105DataCriacao,
            };
        }
    }
}
