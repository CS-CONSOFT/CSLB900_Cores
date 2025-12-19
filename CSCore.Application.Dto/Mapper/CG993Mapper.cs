using CSCore.Application.Dto.Dtos.CG;
using CSCore.Application.Dto.Dtos.CG.CG08X.CG082;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper
{
    public static class CG993Mapper
    {
        public static DtoGetCG993 ToDtoGet(this csicp_cg993_st entity)
        {
            return new DtoGetCG993
            {
                Id = entity.Id,
                Label = entity.Label,
                Order = entity.Order,
                IsActive = entity.IsActive,
                Resumido1 = entity.Resumido1,
                Resumido2 = entity.Resumido2
            };
        }
    }
}
