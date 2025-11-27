using CSCore.Application.Dto.Dtos.CG.CG003;
using CSCore.Application.Dto.Dtos.CG.CG00X.CG004;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG004Mapper
    {
        public static DtoGetCG004Padrao ToDtoGetPadrao(this Osusr8dwCsicpCg004 entity)
        {
            return new DtoGetCG004Padrao
            {
                TenantId = entity.TenantId,
                Cg004Id = entity.Cg004Id,
                Cg004FilialId = entity.Cg004FilialId,
                Cg004Codigo = entity.Cg004Codigo,
                Cg004Descricao = entity.Cg004Descricao,
                Cg004TipoId = entity.Cg004TipoId,
                Cg004Isactive = entity.Cg004Isactive
            };
        }
    }
}
