using CSCore.Domain;
using CSSY103.C82Application.Dto.SY001.SY007;

namespace CSSY103.C82Application.Mapper
{
    public static class SY007ExtensionMethods
    {
        public static Csicp_Sy007 ToEntity(this Dto_LinkSy007 dto)
        {
            return new Csicp_Sy007
            {
                Sy007Grupoid = dto.Sy007Grupoid,
                Sy007RegraestaticaId = dto.Sy007RegraestaticaId
            };
        }

        public static Dto_LinkGetSy007 ToDtoGetSy007(this Csicp_Sy007 entity)
        {
            return new Dto_LinkGetSy007
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy007Grupoid = entity.Sy007Grupoid,
                Sy007RegraestaticaId = entity.Sy007RegraestaticaId,
                NavSy007Regraestatica = entity.Sy007Regraestatica
            };
        }
    }
}
