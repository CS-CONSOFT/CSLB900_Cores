using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG045;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG046;
using CSCore.Domain.CS_Models.CSICP_GG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG046Mapper
    {
        public static DtoGetGG046 ToDtoGet(this OsusrE9aCsicpGg046 entity)
        {
            return new DtoGetGG046
            {
                TenantId = entity.TenantId,
                Gg046Id = entity.Gg046Id,
                Gg046Seq = entity.Gg046Seq,
                Gg045Id = entity.Gg045Id,
                Gg046SaldoentId = entity.Gg046SaldoentId,
                Gg046Qtd = entity.Gg046Qtd,
                Gg046StatId = entity.Gg046StatId,
                Gg046EntsaiId = entity.Gg046EntsaiId,
                Gg046Isnovo = entity.Gg046Isnovo,
                Gg046Descricaosaldo = entity.Gg046Descricaosaldo,
                Gg046Codbarrasalfa = entity.Gg046Codbarrasalfa,
                Gg046Entsai = entity.Gg046Entsai,
                Gg046Saldoent = entity.Nav_Gg250Saldoent?.ToDtoGetSimples(),
                Gg046Stat = entity.Gg046Stat
            };
        }
    }
}