using CSCore.Domain;
using CSSY103.C82Application.Dto.SY001.SY015;

namespace CSSY103.C82Application.Mapper
{
    public static class SY015ExtensionMethods
    {
        public static Csicp_Sy015 ToEntity(this Dto_CreateUpdateLinkSy015 dto)
        {
            return new Csicp_Sy015
            {
                Sy015Grupoid = dto.Sy015Grupoid,
                Sy903SubmenuId = dto.Sy903SubmenuId
            };
        }

        public static Dto_LinkGetSy015 ToDtoGetSy015(this Csicp_Sy015 entity)
        {
            return new Dto_LinkGetSy015
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy015Grupoid = entity.Sy015Grupoid,
                Sy903SubmenuId = entity.Sy903SubmenuId
            };
        }
    }
}
