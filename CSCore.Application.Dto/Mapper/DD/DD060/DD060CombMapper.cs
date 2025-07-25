using CSCore.Domain.CS_Models.CSICP_DD;
using EnviaNFeHercules.C82Application.Dto.DD.DD060;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Mapper.DD00X.DD060
{
    public static class DD060CombMapper
    {
        public static DtoGetDD060Comb ToDtoGetDD060Comb(this CSICP_DD060comb entity)
        {
            return new DtoGetDD060Comb
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Dd060Id = entity.Dd060Id,
                Indimport = entity.Indimport,
                Cuforig = entity.Cuforig,
                Porig = entity.Porig
            };
        }
    }
}
