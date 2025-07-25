using CSCore.Domain.CS_Models.CSICP_SYS;
using CSSY103.C82Application.Dto.SY002;

namespace CSSY103.C82Application.Mapper
{
    public static class SY002ExtensionMethods
    {
        public static Csicp_Sy002 ToEntity(this Dto_CreateUpdateSy002 dto)
        {
            return new Csicp_Sy002
            {
                Sy002Grupo = dto.Sy002Grupo,
                Sy002Descricao = dto.Sy002Descricao
            };
        }

        public static Dto_GetSy002 ToDtoGetSy002(this Csicp_Sy002 entity)
        {
            return new Dto_GetSy002
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy002Grupo = entity.Sy002Grupo,
                Sy002Descricao = entity.Sy002Descricao
            };
        }
    }
}

