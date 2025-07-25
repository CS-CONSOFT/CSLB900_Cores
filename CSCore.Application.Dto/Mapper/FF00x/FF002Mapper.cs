using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF002;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF00x
{
    public static class FF002Mapper
    {
        public static DtoGetFF002 ToDtoGet(this RepoCSICP_FF002 entity)
        {
            return new DtoGetFF002
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff002Tiporegistro = entity.Ff002Tiporegistro,
                Ff002Codigo = entity.Ff002Codigo,
                Ff002Motivo = entity.Ff002Motivo,
                Ff002Peso = entity.Ff002Peso,
                NavFF002_Mod = entity.NavFF002_Mod
            };
        }
    }
}
