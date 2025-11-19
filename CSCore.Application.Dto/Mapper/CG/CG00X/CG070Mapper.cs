using CSCore.Application.Dto.Dtos.CG.CG070;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG070Mapper
    {
        public static DtoGetCG070 ToDtoGet(this Osusr8dwCsicpCg070 entity)
        {
            return new DtoGetCG070
            {
                TenantId = entity.TenantId,
                Cg070Id = entity.Cg070Id,
                Cg070Datahora = entity.Cg070Datahora,
                Cg070Continstatusinterid = entity.Cg070Continstatusinterid,
                Cg070Processalista = entity.Cg070Processalista
            };
        }
    }
}