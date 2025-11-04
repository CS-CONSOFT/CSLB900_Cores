using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG005;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG005Mapper
    {
        public static DtoGetCG005 ToDtoGet(this CSICP_CG005 entity)
        {
            return new DtoGetCG005
            {
                TenantId = entity.TenantId,
                Cg005Id = entity.Cg005Id,
                Cg005FilialId = entity.Cg005FilialId,
                Cg005Codigo = entity.Cg005Codigo,
                Cg005Historico = entity.Cg005Historico,
                Cg005Historicoresumido = entity.Cg005Historicoresumido,
                Cg005Isactive = entity.Cg005Isactive,
                NavBB001Estab_CG005 = entity.NavBB001Estab_CG005?.ToDtoGetExibicao()
            };
        }

        public static DtoGetCG005Padrao ToDtoGetPadrao(this CSICP_CG005 entity)
        {
            return new DtoGetCG005Padrao
            {
                TenantId = entity.TenantId,
                Cg005Id = entity.Cg005Id,
                Cg005FilialId = entity.Cg005FilialId,
                Cg005Codigo = entity.Cg005Codigo,
                Cg005Historico = entity.Cg005Historico,
                Cg005Historicoresumido = entity.Cg005Historicoresumido,
                Cg005Isactive = entity.Cg005Isactive
            };
        }
    }
}