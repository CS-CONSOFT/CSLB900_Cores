using CSCore.Domain.CS_Models.CSICP_DD;
using EnviaNFeHercules.C82Application.Dto.DD.DD060;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Mapper.DD00X.DD060
{
    public static class DD060CombLa01Mapper
    {
        public static DtoGetDD060CombLa01 ToDtoGetDD060CombLa01(this CSICP_DD060combla01 entity)
        {
            return new DtoGetDD060CombLa01
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Dd060Id = entity.Dd060Id,
                La02Cprodanp = entity.La02Cprodanp,
                La03Descanp = entity.La03Descanp,
                La03aPglp = entity.La03aPglp,
                La03bPgnn = entity.La03bPgnn,
                La03cPgni = entity.La03cPgni,
                La03dVpart = entity.La03dVpart,
                La04Codif = entity.La04Codif,
                La05Qtemp = entity.La05Qtemp,
                La17Pbio = entity.La17Pbio,
                La06Ufcons = entity.La06Ufcons
            };
        }
    }
}
