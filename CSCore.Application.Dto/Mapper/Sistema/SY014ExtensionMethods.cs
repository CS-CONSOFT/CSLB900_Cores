using CSCore.Domain.CS_Models.CSICP_SYS;
using CSSY103.C82Application.Dto.SY001.SY014;

namespace CSSY103.C82Application.Mapper
{
    public static class SY014ExtensionMethods
    {
        public static Csicp_Sy014 ToEntity(this Dto_CreateUpdateLinkSy014 dto)
        {
            return new Csicp_Sy014
            {
                Sy014Grupoid = dto.Sy014Grupoid,
                Sy902MenuId = dto.Sy902MenuId
            };
        }

        public static Dto_LinkGetSy014 ToDtoGetSy014(this Csicp_Sy014 entity)
        {
            return new Dto_LinkGetSy014
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy014Grupoid = entity.Sy014Grupoid,
                Sy902MenuId = entity.Sy902MenuId
            };
        }

        public static Dto_LinkGetComMenuSy014 ToDtoGetComMenu(this Csicp_Sy014 entity)
        {
            return new Dto_LinkGetComMenuSy014
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy014Grupoid = entity.Sy014Grupoid,
                Sy902MenuId = entity.Sy902MenuId,
                CsicpSy902Menu = entity.CsicpSy902Menu

            };
        }
    }
}
