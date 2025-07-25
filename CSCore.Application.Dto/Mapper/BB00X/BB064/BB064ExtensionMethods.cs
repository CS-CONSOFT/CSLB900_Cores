
using CSBS101._82Application.Dto.BB00X.BB06X.BB064;
using CSCore.Domain;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB06X.BB064
{
    public static class BB064ExtensionMethods
    {
        public static CSICP_Bb064 ToEntity(this Dto_CreateUpdateBB064 dto)
        {
            return new CSICP_Bb064
            {
                Bb064Descricao = dto.Bb064Descricao,
                Bb064Isactive = true
            };
        }

        public static Dto_GetBB064 ToDtoGet(this CSICP_Bb064 entity)
        {
            return new Dto_GetBB064
            {
                TenantId = entity.TenantId,
                Bb064Fxetariaid = entity.Bb064Fxetariaid,
                Bb064Descricao = entity.Bb064Descricao,
                Bb064Isactive = entity.Bb064Isactive,
            };
        }
    }
}
