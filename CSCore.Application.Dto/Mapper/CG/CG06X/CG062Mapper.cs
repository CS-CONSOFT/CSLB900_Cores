using CSCore.Application.Dto.Dtos.CG.CG06X.CG062;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG06X
{
    public static class CG062Mapper
    {
        public static DtoGetCG062 ToDtoGetCG062(Osusr8dwCsicpCg062 entity)
        {
            return new DtoGetCG062
            {
                TenantId = entity.TenantId,
                Cg062Id = entity.Cg062Id,
                Cg062Regramentoid = entity.Cg062Regramentoid,
                Cg062Eventovalortpid = entity.Cg062Eventovalortpid,
                Cg062Contadebid = entity.Cg062Contadebid,
                Cg062Histdebid = entity.Cg062Histdebid,
                Cg062Contacredid = entity.Cg062Contacredid,
                Cg062Histcredid = entity.Cg062Histcredid,
                Cg062Eventovalortpdebid = entity.Cg062Eventovalortpdebid,
                Cg062Eventovalortpcredid = entity.Cg062Eventovalortpcredid,
                Cg062Isignorevalor = entity.Cg062Isignorevalor,
                Cg062CtagerencialDebn2Id = entity.Cg062CtagerencialDebn2Id,
                Cg062CtagerencialDebn3Id = entity.Cg062CtagerencialDebn3Id,
                Cg062CtagerencialDebn4Id = entity.Cg062CtagerencialDebn4Id,
                Cg062CtagerencialCren2Id = entity.Cg062CtagerencialCren2Id,
                Cg062CtagerencialCren3Id = entity.Cg062CtagerencialCren3Id,
                Cg062CtagerencialCren4Id = entity.Cg062CtagerencialCren4Id
            };
        }
    }
}