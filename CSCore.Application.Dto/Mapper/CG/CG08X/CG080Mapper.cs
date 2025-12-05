using CSCore.Application.Dto.Dtos.CG.CG08X.CG080;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG08X
{
    public static class CG080Mapper
    {
        public static DtoGetCG080 ToDtoGet(this Osusr8dwCsicpCg080 entity)
        {
            return new DtoGetCG080
            {
                TenantId = entity.TenantId,
                Cg080Id = entity.Cg080Id,
                Cg080Nome = entity.Cg080Nome,
                Cg080Dtvigenciaini = entity.Cg080Dtvigenciaini,
                Cg080Dtvigenciafim = entity.Cg080Dtvigenciafim,
                Cg080Isactive = entity.Cg080Isactive,
                Cg080Isprojfromprov = entity.Cg080Isprojfromprov,
            };
        }
    }
}