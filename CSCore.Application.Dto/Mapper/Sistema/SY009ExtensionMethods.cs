using CSCore.Domain;
using CSSY103.C82Application.Dto.SY001.SY009;

namespace CSSY103.C82Application.Mapper
{
    public static class SY009ExtensionMethods
    {
        public static Csicp_Sy009 ToEntity(this Dto_LinkSy009 dto)
        {
            return new Csicp_Sy009
            {
                Sy009Grupoid = dto.Sy009Grupoid,
                Sy904ProgramaId = dto.Sy904ProgramaId
            };
        }

        public static Dto_LinkGetSy009 ToDtoGetSy009(this Csicp_Sy009 entity)
        {
            return new Dto_LinkGetSy009
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy009Grupoid = entity.Sy009Grupoid,
                Sy904ProgramaId = entity.Sy904ProgramaId
            };
        }
    }
}
