using CSCore.Application.Dto.Dtos.CG.CG00X.CG008;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG008Mapper
    {
        public static DtoGetCG008 ToDtoGet(this CSICP_CG008 entity)
        {
            return new DtoGetCG008
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
