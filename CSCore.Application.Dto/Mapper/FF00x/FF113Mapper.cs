using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF113;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF113;

namespace CSCore.Application.Dto.Mapper.FF00x
{
    public static class FF113Mapper
    {
        public static DtoGetFF113 ToDtoGet(this RepoDtoCSICP_FF113 entity)
        {
            return new DtoGetFF113
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff113Usuariopropr = entity.Ff113Usuariopropr,
                Ff113Filialid = entity.Ff113Filialid,
                Ff113RefConfBanco = entity.Ff113RefConfBanco,
                Ff113Dataregistro = entity.Ff113Dataregistro,
                Ff113Nota = entity.Ff113Nota,
                Ff113Lote = entity.Ff113Lote,
                Ff113Desclote = entity.Ff113Desclote,
                Ff113Borderoid = entity.Ff113Borderoid,
                Ff113Tipo = entity.Ff113Tipo,
                Ff113Retornoid = entity.Ff113Retornoid,
                Nn015Bxtesourariaid = entity.Nn015Bxtesourariaid,
                Ff113Codgmovtoremessa = entity.Ff113Codgmovtoremessa,
                NavBB001 = entity.NavBB001?.ToDtoGetExibicao(),
                NavFF112 = entity.NavFF112?.ToDtoGetFF112Simples(),
                NavFF113Tipo = entity.NavFF113Tipo,
                NavSy001 = entity.NavSy001?.ToDtoGetSimples(),

            };
        }
    }
}