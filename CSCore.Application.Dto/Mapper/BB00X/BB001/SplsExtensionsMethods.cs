using CSBS101._82Application.Dto.BB00X.BB001.BB001Spls;
using CSCore.Domain;


namespace CSBS101._82Application.Mapper.BB00X.BB00X.BB001
{
    public static class SplsExtensionsMethods
    {
        public static CSICP_BB001Spls ToEntity(this Dto_LinkSpls dto, int tenant, string uuid)
        {
            return new CSICP_BB001Spls
            {
                TenantId = tenant,
                Bb001SimplesId = uuid,
                Bb001Id = dto.Bb001Id,
                Bb001SimplespartId = dto.Bb001SimplespartId,
                Bb001AliqSimples = dto.Bb001AliqSimples,
                Bb001AliqIrpj = dto.Bb001AliqIrpj,
                Bb001AliqCsll = dto.Bb001AliqCsll,
                Bb001AliqCofins = dto.Bb001AliqCofins,
                Bb001AliqPisPasep = dto.Bb001AliqPisPasep,
                Bb001AliqCpp = dto.Bb001AliqCpp,
                Bb001AliqIcms = dto.Bb001AliqIcms,
                Bb001AliqIpi = dto.Bb001AliqIpi,
                Bb001AliqIss = dto.Bb001AliqIss,
            };
        }

        public static Dto_GetSplsFromBB001 ToDtoGet(this CSICP_BB001Spls entity)
        {
            return new Dto_GetSplsFromBB001
            {
                TenantId = entity.TenantId,
                Bb001SimplesId = entity.Bb001SimplesId,
                Bb001Id = entity.Bb001Id,
                Bb001SimplespartId = entity.Bb001SimplespartId,
                Bb001AliqSimples = entity.Bb001AliqSimples,
                Bb001AliqIrpj = entity.Bb001AliqIrpj,
                Bb001AliqCsll = entity.Bb001AliqCsll,
                Bb001AliqCofins = entity.Bb001AliqCofins,
                Bb001AliqPisPasep = entity.Bb001AliqPisPasep,
                Bb001AliqCpp = entity.Bb001AliqCpp,
                Bb001AliqIcms = entity.Bb001AliqIcms,
                Bb001AliqIpi = entity.Bb001AliqIpi,
                Bb001AliqIss = entity.Bb001AliqIss,
                Bb001Simplespart = entity.Bb001Simplespart
            };
        }
    }
}
