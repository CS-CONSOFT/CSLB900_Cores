
using CSBS101._82Application.Dto.BB00X.BB06X.BB065;
using CSBS101._82Application.ExtensionsMethods.BB00X.BB06X.BB060;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB06X.BB065
{
    public static class BB065ExtensionMethods
    {
        public static CSICP_Bb065 ToEntity(this Dto_CreateUpdateBB065 dto)
        {
            var entity = new CSICP_Bb065
            {
                Bb064Fxetariaid = dto.Bb064Fxetariaid,
                Bb062Convenioid = dto.Bb062Convenioid,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB065 ToDtoGet(this CSICP_Bb065 entity)
        {
            return new Dto_GetBB065
            {
                TenantId = entity.TenantId,
                Bb065Id = entity.Bb065Id,
                Bb064Fxetariaid = entity.Bb064Fxetariaid,
                Bb062Convenioid = entity.Bb062Convenioid,
                NavBb062Convenio = entity.Bb062Convenio?.ToDtoGetExibicao(),
                // NavBb064Fxetaria = entity.Bb064Fxetaria?.ToDtoGet(),
            };
        }
    }
}
