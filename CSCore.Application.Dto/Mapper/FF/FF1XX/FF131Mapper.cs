using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF131;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF131;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF131Mapper
    {
        public static DtoGetFF131 ToDtoGet(this RepoDtoCSICP_FF131 entity)
        {
            return new DtoGetFF131
            {
                TenantId = entity.TenantId,
                Ff131Id = entity.Ff131Id,
                Ff131Filialid = entity.Ff131Filialid,
                Ff131Dregistro = entity.Ff131Dregistro,
                Ff131Contaid = entity.Ff131Contaid,
                Ff131TomadorContaid = entity.Ff131TomadorContaid,
                Ff131Usuarioid = entity.Ff131Usuarioid,
                Ff131Observacao = entity.Ff131Observacao,
                Ff131Isefetivado = entity.Ff131Isefetivado,
                Ff131Protocolo = entity.Ff131Protocolo,
                NavBB001Filial = entity.NavBB001Filial!.ToDtoGetExibicao(),
                NavBB012Conta = entity.NavBB012Conta!.ToDtoBB012Exibicao(),
                NavBB012TomadorConta = entity.NavBB012TomadorConta!.ToDtoBB012_Exibicao(),
                NavSy001Usuario = entity.NavSy001Usuario!.ToDtoGetSimples()
            };
        }
    }
}
