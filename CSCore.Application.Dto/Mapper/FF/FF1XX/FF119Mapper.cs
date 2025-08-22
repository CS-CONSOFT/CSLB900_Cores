using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF119;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF119;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF119Mapper
    {
        public static DtoGetFF119 ToDtoGet(this RepoDtoCSICP_FF119 entity)
        {
            return new DtoGetFF119
            {
                TenantId = entity.TenantId,
                Ff119Id = entity.Ff119Id,
                Ff112Id = entity.Ff112Id!,
                Ff119Regid = entity.Ff119Regid,
                Ff119Posicaode = entity.Ff119Posicaode,
                Ff119Posicaoate = entity.Ff119Posicaoate,
                Ff119Conteudo = entity.Ff119Conteudo,
                Ff119Descricao = entity.Ff119Descricao,
                NavFF112Reg = entity.NavFF112Reg
            };
        }
    }
}
