using CSCore.Domain.CS_Models.CSICP_SYS.Depreciadas_Tabelas;
using CSSY103.C82Application.Dto.SY001.SY019;

namespace CSSY103.C82Application.Mapper
{
    public static class SY019ExtensionMethods
    {
        public static Csicp_Sy019 ToEntity(this Dto_CreateUpdateLinkSy019 dto)
        {
            return new Csicp_Sy019
            {
                Sy019Userid = dto.Sy019Userid,
                Sy904ProgramaId = dto.Sy904ProgramaId,
                Sy019Isactive = dto.Sy019Isactive,

            };
        }

        public static Dto_LinkGetSy019 ToDtoGetSy019(this Csicp_Sy019 entity)
        {
            return new Dto_LinkGetSy019
            {
                TenantId = entity.TenantId,
                Sy019Id = entity.Sy019Id,
                Sy019Userid = entity.Sy019Userid,
                Sy904ProgramaId = entity.Sy904ProgramaId,
                Sy019Isactive = entity.Sy019Isactive,
                Sy019User = entity.Sy019User,

            };
        }
    }
}
