using CSCore.Domain.CS_Models.CSICP_SYS;
using CSSY103.C82Application.Dto.SY001.SY005;

namespace CSSY103.C82Application.Mapper
{
    public static class Sy005ExtensionMethods
    {
        public static Csicp_Sy005 ToEntity(this Dto_LinkSy005 dto)
        {
            return new Csicp_Sy005
            {
                Sy005Grupoid = dto.Sy005Grupoid,
                Sy005Userid = dto.Sy005Userid,
                Sy005Grupo = dto.Sy005Grupo
            };
        }

        public static Dto_LinkGetSy005 ToDtoGet(this Csicp_Sy005 entity)
        {
            return new Dto_LinkGetSy005
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy005Grupoid = entity.Sy005Grupoid,
                Sy005Grupo = entity.Sy005Grupo
            };
        }
    }
}

