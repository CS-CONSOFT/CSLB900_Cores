using CSCore.Application.Dto.Dtos.CG.CG05X.CG052;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG05X
{
    public static class CG052Mapper
    {
        public static DtoGetCG052 ToDtoGetCG052(this Osusr8dwCsicpCg052 entity)
        {
            return new DtoGetCG052
            {
                TenantId = entity.TenantId,
                Cg052Id = entity.Cg052Id,
                Cg052Txcodigo = entity.Cg052Txcodigo,
                Cg052Txdescricao = entity.Cg052Txdescricao,
                Cg052Txcomando = entity.Cg052Txcomando,
                Cg052Txtabelas = entity.Cg052Txtabelas,
                Cg052Moduloid = entity.Cg052Moduloid,
                NavModuloID_CG052 = entity.NavModuloID_CG052
            };
        }

        public static DtoGetCG052Padrao ToDtoGetCG052Padrao(this Osusr8dwCsicpCg052 entity)
        {
            return new DtoGetCG052Padrao
            {
                TenantId = entity.TenantId,
                Cg052Id = entity.Cg052Id,
                Cg052Txcodigo = entity.Cg052Txcodigo,
                Cg052Txdescricao = entity.Cg052Txdescricao,
                Cg052Txcomando = entity.Cg052Txcomando,
                Cg052Txtabelas = entity.Cg052Txtabelas,
                Cg052Moduloid = entity.Cg052Moduloid
            };
        }
    }
}