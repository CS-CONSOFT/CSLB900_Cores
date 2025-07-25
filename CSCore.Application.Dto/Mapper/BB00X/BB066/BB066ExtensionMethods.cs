
using CSBS101._82Application.Dto.BB00X.BB06X.BB066;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB06X.BB066
{
    public static class BB066ExtensionMethods
    {
        public static CSICP_Bb066 ToEntity(this Dto_CreateUpdateBB066 dto)
        {
            var entity = new CSICP_Bb066
            {
                Bb066Fxetariaid = dto.Bb066Fxetariaid,
                Bb066Faixade = dto.Bb066Faixade,
                Bb066Faixaate = dto.Bb066Faixaate,
                Bb066Valor = dto.Bb066Valor
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB066 ToDtoGet(this CSICP_Bb066 entity)
        {
            return new Dto_GetBB066
            {
                TenantId = entity.TenantId,
                Bb066Id = entity.Bb066Id,
                Bb066Fxetariaid = entity.Bb066Fxetariaid,
                Bb066Faixade = entity.Bb066Faixade,
                Bb066Faixaate = entity.Bb066Faixaate,
                Bb066Valor = entity.Bb066Valor,
                //NavBb066Fxetaria = entity.Bb066Fxetaria?.ToDtoGet()
            };
        }
    }
}
