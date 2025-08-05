using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB009;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF105;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF105;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF105Mapper
    {
        public static DtoGetFF105 ToDtoGetFF105(this RepoDtoCSICP_FF105 entity)
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
                NavBB001 = entity.NavBB001?.ToDtoGetExibicao(),
                NavBB006 = entity.NavBB006?.ToDtoGetExibicao(),
                NavBB009 = entity.NavBB009?.ToDtoGetBB009_Exibicao(),
                NavFF102ApiBanco = entity.NavFF102ApiBanco,
                NavFF105Status = entity.NavFF105Status,
                NavFF105Statusapi = entity.NavFF105Statusapi,
            };
        }
    }
}
