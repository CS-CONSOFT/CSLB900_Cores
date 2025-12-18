using CSCore.Application.Dto.Dtos.CG.CG05X.CG055;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG05X
{
    public static class CG055Mapper
    {
        public static DtoGetCG055 ToDtoGetCG055(this Osusr8dwCsicpCg055 entity)
        {
            return new DtoGetCG055
            {
                TenantId = entity.TenantId,
                Cg055Id = entity.Cg055Id,
                Cg055Txcodigo = entity.Cg055Txcodigo,
                Cg055Txdescricao = entity.Cg055Txdescricao,
                Cg055Moduloid = entity.Cg055Moduloid,
                NavModuloID_CG055 = entity.NavModuloID_CG055
            };
        }

        public static DtoGetCG055Padrao ToDtoGetCG055Padrao(this Osusr8dwCsicpCg055 entity)
        {
            return new DtoGetCG055Padrao
            {
                TenantId = entity.TenantId,
                Cg055Id = entity.Cg055Id,
                Cg055Txcodigo = entity.Cg055Txcodigo,
                Cg055Txdescricao = entity.Cg055Txdescricao,
                Cg055Moduloid = entity.Cg055Moduloid
            };
        }
    }
}