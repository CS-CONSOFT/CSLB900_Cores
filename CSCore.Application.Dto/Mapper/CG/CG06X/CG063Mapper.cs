using CSCore.Application.Dto.Dtos.CG.CG06X.CG063;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG06X
{
    public static class CG063Mapper
    {
        public static DtoGetCG063 ToDtoGetCG063(Osusr8dwCsicpCg063 entity)
        {
            return new DtoGetCG063
            {
                TenantId = entity.TenantId,
                Cg063Id = entity.Cg063Id,
                Cg063Regramentoid = entity.Cg063Regramentoid,
                Cg063Parametroid = entity.Cg063Parametroid,
                Cg063Eventopartpid = entity.Cg063Eventopartpid
            };
        }
    }
}