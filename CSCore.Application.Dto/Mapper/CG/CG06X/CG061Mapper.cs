using CSCore.Application.Dto.Dtos.CG.CG06X.CG061;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG06X
{
    public static class CG061Mapper
    {
        public static DtoGetCG061 ToDtoGetCG061(this Osusr8dwCsicpCg061 entity)
        {
            return new DtoGetCG061
            {
                TenantId = entity.TenantId,
                Cg061Id = entity.Cg061Id,
                Cg061Regramentoid = entity.Cg061Regramentoid,
                Cg061Estabid = entity.Cg061Estabid
            };
        }
    }
}