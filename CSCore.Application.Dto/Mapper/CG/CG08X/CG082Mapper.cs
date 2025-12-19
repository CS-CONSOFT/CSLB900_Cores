using CSCore.Application.Dto.Dtos.CG.CG08X.CG082;
using CSCore.Application.Dto.Mapper.CG.CG00X;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG08X
{
    public static class CG082Mapper
    {
        public static DtoGetCG082 ToDtoGet(this Osusr8dwCsicpCg082 entity)
        {
            return new DtoGetCG082
            {
                TenantId = entity.TenantId,
                Cg082Id = entity.Cg082Id,
                Cg082Contrelregid = entity.Cg082Contrelregid,
                Cg082Contcontaid = entity.Cg082Contcontaid,
                Cg082Dateinicial = entity.Cg082Dateinicial,
                Cg082Datefinal = entity.Cg082Datefinal,
                NavCG006ContConta_CG082 = entity.NavCG006ContConta_CG082?.ToDtoGetPadrao(),
                NavCG081ContRelRegID_CG082 = entity.NavCG081ContRelRegID_CG082?.ToDtoGetPadrao()
            };
        }

        public static DtoGetCG082Padrao ToDtoGetPadrao(this Osusr8dwCsicpCg082 entity)
        {
            return new DtoGetCG082Padrao
            {
                TenantId = entity.TenantId,
                Cg082Id = entity.Cg082Id,
                Cg082Contrelregid = entity.Cg082Contrelregid,
                Cg082Contcontaid = entity.Cg082Contcontaid,
                Cg082Dateinicial = entity.Cg082Dateinicial,
                Cg082Datefinal = entity.Cg082Datefinal
            };
        }
    }
}