using CSCore.Application.Dto.Dtos.CG.CG05X.CG054;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG05X
{
    public static class CG054Mapper
    {
        public static DtoGetCG054 ToDtoGetCG054(this Osusr8dwCsicpCg054 entity)
        {
            return new DtoGetCG054
            {
                TenantId = entity.TenantId,
                Cg054Id = entity.Cg054Id,
                Cg054Eventotpid = entity.Cg054Eventotpid,
                Cg054Valortpid = entity.Cg054Valortpid
            };
        }
    }
}