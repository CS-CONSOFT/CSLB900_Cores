

using CSBS101._82Application.Dto.BB00X.BB05X.BB051;
using CSBS101._82Application.ExtensionsMethods.BB00X.BB05X.BB050;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB05X.BB051
{
    public static class BB051ExtensionMethods
    {
        public static CSICP_Bb051 ToEntity(this Dto_CreateUpdateBB051 dto)
        {
            var entity = new CSICP_Bb051
            {
                Bb050Id = dto.Bb050Id,
                Bb051Formapagtoid = dto.Bb051Formapagtoid,
                Bb051Maxparcela = dto.Bb051Maxparcela
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB051 ToDtoGet(this CSICP_Bb051 entity)
        {
            return new Dto_GetBB051
            {
                TenantId = entity.TenantId,
                Bb051Id = entity.Bb051Id,
                Bb050Id = entity.Bb050Id,
                Bb051Formapagtoid = entity.Bb051Formapagtoid,
                Bb051Maxparcela = entity.Bb051Maxparcela,
                NavBb050 = entity.Bb050?.ToDtoGet(),
                NavBb051Formapagto = entity.Bb051Formapagto?.ToDtoGet()
            };
        }
    }
}
