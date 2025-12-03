using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X;
using CSCore.Domain.CS_Models.CSICP_GG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG993Mapper
    {
        public static DtoGetGG993 ToDtoGetGG993(this OsusrE9aCsicpGg993 entity)
        {
            return new DtoGetGG993
            {
                TenantId = entity.TenantId,
                Gg993Id = entity.Gg993Id,
                Gg993Empresaid = entity.Gg993Empresaid,
                Gg993Saldoid = entity.Gg993Saldoid,
                Gg993EstoqMin = entity.Gg993EstoqMin,
                Gg993EstqMax = entity.Gg993EstqMax,
                Gg993QtdeReposicao = entity.Gg993QtdeReposicao,
                Gg993Createon = entity.Gg993Createon,
                Gg041RiId = entity.Gg041RiId,
                Gg028Extratoid = entity.Gg028Extratoid,
                Gg993Isprocessado = entity.Gg993Isprocessado
            };
        }
    }
}
