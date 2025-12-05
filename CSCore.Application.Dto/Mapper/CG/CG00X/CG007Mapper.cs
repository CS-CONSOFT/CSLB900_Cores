using CSCore.Application.Dto.Dtos.CG.CG00X.CG007;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG00X
{
    public static class CG007Mapper
    {
        public static DtoGetCG007 ToDtoGet(this Osusr8dwCsicpCg007 entity)
        {
            return new DtoGetCG007
            {
                TenantId = entity.TenantId,
                Cg007Id = entity.Cg007Id,
                Cg007FilialId = entity.Cg007FilialId,
                Cg007Codigo = entity.Cg007Codigo,
                Cg007Descricao = entity.Cg007Descricao,
                Cg007Objetivo = entity.Cg007Objetivo,
                Cg007Isactive = entity.Cg007Isactive,
                Cg007DataInicio = entity.Cg007DataInicio,
                Cg007DataFim = entity.Cg007DataFim,
                Cg007UserpropId = entity.Cg007UserpropId,
                Cg007StatusId = entity.Cg007StatusId
            };
        }
    }
}