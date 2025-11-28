using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG00X.CG000;
using CSCore.Application.Dto.Mapper.NN._015;
using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.CS_Models.CSICP_NN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG000Mapper
    {
        public static DtoGetCG000 ToDtoGet(this CSICP_CG000 entity)
        {
            return new DtoGetCG000
            {
                TenantId = entity.TenantId,
                Cg000Id = entity.Cg000Id,
                Cg000Filialid = entity.Cg000Filialid,
                Cg000Graus = entity.Cg000Graus,
                Cg000Dgrau1 = entity.Cg000Dgrau1,
                Cg000Dgrau2 = entity.Cg000Dgrau2,
                Cg000Dgrau3 = entity.Cg000Dgrau3,
                Cg000Dgrau4 = entity.Cg000Dgrau4,
                Cg000Dgrau5 = entity.Cg000Dgrau5,
                Cg000Mascaracta = entity.Cg000Mascaracta,
                Cg000Grausctager = entity.Cg000Grausctager,
                Cg000Dgrau1Ctager = entity.Cg000Dgrau1Ctager,
                Cg000Dgrau2Ctager = entity.Cg000Dgrau2Ctager,
                Cg000Dgrau3Ctager = entity.Cg000Dgrau3Ctager,
                Cg000Dgrau4Ctager = entity.Cg000Dgrau4Ctager,
                Cg000Dgrau5Ctager = entity.Cg000Dgrau5Ctager,
                Cg000Mascaractager = entity.Cg000Mascaractager,
                Cg000Ultcodgredz = entity.Cg000Ultcodgredz,
                Cg000Usacalendario = entity.Cg000Usacalendario,
                NavBB001Estab_CG000 = entity.NavBB001Estab_CG000?.ToDtoGetSimples(), 
                NavStatica_CG000 =  entity.NavStatica_CG000
            };

        }

        public static DtoGetCG000Padrao ToDtoGetPadrao(this CSICP_CG000 entity)
        {
            return new DtoGetCG000Padrao
            {
                TenantId = entity.TenantId,
                Cg000Id = entity.Cg000Id,
                Cg000Filialid = entity.Cg000Filialid,
                Cg000Graus = entity.Cg000Graus,
                Cg000Dgrau1 = entity.Cg000Dgrau1,
                Cg000Dgrau2 = entity.Cg000Dgrau2,
                Cg000Dgrau3 = entity.Cg000Dgrau3,
                Cg000Dgrau4 = entity.Cg000Dgrau4,
                Cg000Dgrau5 = entity.Cg000Dgrau5,
                Cg000Mascaracta = entity.Cg000Mascaracta,
                Cg000Grausctager = entity.Cg000Grausctager,
                Cg000Dgrau1Ctager = entity.Cg000Dgrau1Ctager,
                Cg000Dgrau2Ctager = entity.Cg000Dgrau2Ctager,
                Cg000Dgrau3Ctager = entity.Cg000Dgrau3Ctager,
                Cg000Dgrau4Ctager = entity.Cg000Dgrau4Ctager,
                Cg000Dgrau5Ctager = entity.Cg000Dgrau5Ctager,
                Cg000Mascaractager = entity.Cg000Mascaractager,
                Cg000Ultcodgredz = entity.Cg000Ultcodgredz,
                Cg000Usacalendario = entity.Cg000Usacalendario
            };
        }
    }
}
