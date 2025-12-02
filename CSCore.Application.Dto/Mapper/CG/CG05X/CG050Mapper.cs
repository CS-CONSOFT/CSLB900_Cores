using CSCore.Application.Dto.Dtos.CG.CG05X.CG050;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG05X
{
    public static class CG050Mapper
    {
        public static DtoGetCG050 ToDtoGetCG050(this Osusr8dwCsicpCg050 entity)
        {
            return new DtoGetCG050
            {
                TenantId = entity.TenantId,
                Cg050Id = entity.Cg050Id,
                Cg050Txcodigo = entity.Cg050Txcodigo,
                Cg050Txdescricao = entity.Cg050Txdescricao,
                Cg050Periodicidadeid = entity.Cg050Periodicidadeid,
                Cg050Moduloid = entity.Cg050Moduloid,
                Cg050Flonline = entity.Cg050Flonline,
                Cg050Flencerramento = entity.Cg050Flencerramento,
                Cg050Flperman = entity.Cg050Flperman,
                Cg050Flperexc = entity.Cg050Flperexc,
                Cg050Isactive = entity.Cg050Isactive
            };
        }
    }
}
