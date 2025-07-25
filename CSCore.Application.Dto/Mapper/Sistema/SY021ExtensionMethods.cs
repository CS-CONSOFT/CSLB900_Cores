using CSCore.Domain;
using CSSY103.C82Application.Dto.SY001.SY021;

namespace CSSY103.C82Application.Mapper
{
    public static class SY021ExtensionMethods
    {
        public static Csicp_Sy021 ToEntity(this Dto_CreateUpdateLinkSy021 dto)
        {
            return new Csicp_Sy021
            {
                Sy0221Usuarioid = dto.Sy0221Usuarioid
            };
        }

        public static Dto_LinkGetSy021 ToDtoGetSy021(this Csicp_Sy021 entity)
        {
            return new Dto_LinkGetSy021
            {
                TenantId = entity.TenantId,
                Sy021Id = entity.Sy021Id,
                Sy021Acesso = entity.Sy021Acesso,
                Sy021Dlimite = entity.Sy021Dlimite,
                Sy0221Usuarioid = entity.Sy0221Usuarioid
            };
        }
    }
}
