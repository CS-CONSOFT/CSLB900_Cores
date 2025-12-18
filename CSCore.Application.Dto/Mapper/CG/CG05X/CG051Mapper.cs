using CSCore.Application.Dto.Dtos.CG.CG05X.CG051;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG05X
{
    public static class CG051Mapper
    {
        public static DtoGetCG051 ToDtoGetCG051(this Osusr8dwCsicpCg051 entity)
        {
            return new DtoGetCG051
            {
                TenantId = entity.TenantId,
                Cg051Id = entity.Cg051Id,
                Cg051Eventotpid = entity.Cg051Eventotpid,
                Cg051Parametrotpid = entity.Cg051Parametrotpid,
                Flobrigatorio = entity.Flobrigatorio,
                NavCG050TipoEvento_CG051 = entity.NavCG050TipoEvento_CG051?.ToDtoGetCG050Padrao(),
                NavCG052PrmEvento_CG051 = entity.NavCG052PrmEvento_CG051?.ToDtoGetCG052Padrao()
            };
        }

        public static DtoGetCG051Padrao ToDtoGetCG051Padrao(this Osusr8dwCsicpCg051 entity)
        {
            return new DtoGetCG051Padrao
            {
                TenantId = entity.TenantId,
                Cg051Id = entity.Cg051Id,
                Cg051Eventotpid = entity.Cg051Eventotpid,
                Cg051Parametrotpid = entity.Cg051Parametrotpid,
                Flobrigatorio = entity.Flobrigatorio
            };
        }
    }
}