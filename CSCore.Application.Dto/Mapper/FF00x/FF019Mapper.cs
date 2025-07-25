using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF019;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF00x
{
    public static class FF019Mapper
    {
        public static DtoGetFF019 ToDtoGet(this CSICP_FF019 entity)
        {
            return new DtoGetFF019
            {
                TenantId = entity.TenantId,
                Ff019Id = entity.Ff019Id,
                Ff000Id = entity.Ff000Id,
                Ff019FpagtoId = entity.Ff019FpagtoId,
                Ff019Condicaoid = entity.Ff019Condicaoid,
                Ff000 = entity.Ff000
            };
        }
    }
}
