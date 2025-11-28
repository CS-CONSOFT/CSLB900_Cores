using CSCore.Application.Dto.Dtos.CG.CG06X.CG060;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG06X
{
    public static class CG060Mapper
    {
        public static DtoGetCG060 ToDtoGetCG060(Osusr8dwCsicpCg060 entity)
        {
            return new DtoGetCG060
            {
                TenantId = entity.TenantId,
                Cg060Id = entity.Cg060Id,
                Cg060Eventoid = entity.Cg060Eventoid,
                Cg060Dtini = entity.Cg060Dtini,
                Cg060Dtfim = entity.Cg060Dtfim,
                Cg060Nrnumero = entity.Cg060Nrnumero,
                Cg060Flagrupadeb = entity.Cg060Flagrupadeb,
                Cg060Flagrupacred = entity.Cg060Flagrupacred,
                Cg060Eventotpdebid = entity.Cg060Eventotpdebid,
                Cg060Eventotpcredid = entity.Cg060Eventotpcredid,
                Cg060Txdescricao = entity.Cg060Txdescricao,
                Cg060Estabid = entity.Cg060Estabid,
                Cg060Idprevia = entity.Cg060Idprevia,
                Cg060Qparprenchidos = entity.Cg060Qparprenchidos,
                //NavCG050Evento_CG060 = entity.NavCG050Evento_CG060
            };
        }

    }
}
