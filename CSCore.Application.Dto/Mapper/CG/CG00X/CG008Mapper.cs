using CSCore.Application.Dto.Dtos.CG.CG008;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG008Mapper
    {
        public static DtoGetCG008Padrao ToDtoGetPadrao(this Osusr8dwCsicpCg008 entity)
        {
            return new DtoGetCG008Padrao
            {
                TenantId = entity.TenantId,
                Cg008Id = entity.Cg008Id,
                Cg008Cod = entity.Cg008Cod,
                Cg008Descricao = entity.Cg008Descricao,
                Cg008Descresumida = entity.Cg008Descresumida,
                Cg008Isactive = entity.Cg008Isactive
            };
        }
    }
}
