using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG003;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG003Mapper
    {
        public static DtoGetCG003 ToDtoGet(this CSICP_CG003 entity)
        {
            return new DtoGetCG003
            {
                TenantId = entity.TenantId,
                Cg003Id = entity.Cg003Id,
                Cg003FilialId = entity.Cg003FilialId,
                Cg003Codigo = entity.Cg003Codigo,
                Cg003Descricao = entity.Cg003Descricao,
                Cg003Natureza = entity.Cg003Natureza,
                Cg003Isactive = entity.Cg003Isactive,
                NavBB001_CG003 = entity.NavBB001_CG003?.ToDtoGetExibicao()
            };
        }
    }
}
