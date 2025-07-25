using CSCore.Domain;
using CSSY103.C82Application.Dto.SY001.SY006;


namespace CSSY103.C82Application.Mapper
{
    public static class Sy006ExtensionMethods
    {
        public static Csicp_Sy006 ToEntity(this Dto_LinkSy006 dto)
        {
            return new Csicp_Sy006
            {
                Sy006Userid = dto.Sy006Userid,
                Sy006RegraestaticaId = dto.Sy006RegraestaticaId
            };
        }

        public static Dto_LinkGetSy006 ToDtoGetSy006(this Csicp_Sy006 entity)
        {
            return new Dto_LinkGetSy006
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy006Userid = entity.Sy006Userid,
                Sy006RegraestaticaId = entity.Sy006RegraestaticaId
            };
        }
    }
}

