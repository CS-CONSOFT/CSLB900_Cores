using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG015;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG015Mapper
    {
        public static DtoGetGG015 ToDtoGet(this CSICP_GG015 entity)
        {
            return new DtoGetGG015
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg015Filialid = entity.Gg015Filialid,
                Gg015Subgrupo = entity.Gg015Subgrupo,
                Gg015IsActive = entity.Gg015IsActive,
            };
        }
    }
}
