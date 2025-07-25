using CSCore.Domain.CS_Models.CSICP_DD;
using EnviaNFeHercules.C82Application.Dto.DD.DD044;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Mapper.DD00X
{
    public static class DD044Mapper
    {
        public static DtoGetDD044 ToDtoGetDD044(this CSICP_DD044 entity)
        {
            return new DtoGetDD044
            {
                TenantId = entity.TenantId,
                Dd044Id = entity.Dd044Id,
                Dd040Id = entity.Dd040Id,
                Dd044Tiporegistro = entity.Dd044Tiporegistro,
                Dd044DescricaoCompl = entity.Dd044DescricaoCompl,
                Dd044Filial = entity.Dd044Filial,
                Dd044Ci = entity.Dd044Ci
            };
        }
    }
}
