using CSCore.Domain.CS_Models.CSICP_DD;
using EnviaNFeHercules.C82Application.Dto.DD.DD045;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Mapper.DD00X
{
    public static class DD045Mapper
    {
        public static DtoGetDD045 ToDtoGetDD045(this CSICP_DD045 entity)
        {
            return new DtoGetDD045
            {
                TenantId = entity.TenantId,
                Dd045Id = entity.Dd045Id,
                Dd040Id = entity.Dd040Id,
                Dd045Tiporegistro = entity.Dd045Tiporegistro,
                Dd045Nomecampo = entity.Dd045Nomecampo,
                Dd045DescricaoCompl = entity.Dd045DescricaoCompl
            };
        }
    }
}
