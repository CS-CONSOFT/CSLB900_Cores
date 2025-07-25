

using CSBS101._82Application.Dto.BB00X.BB032;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB032ExtensionMethods
    {
        public static CSICP_Bb032 ToEntity(this Dto_CreateUpdateBB032 dto)
        {
            var entity = new CSICP_Bb032
            {
                Bb032Codgcargoid = dto.Bb032Codgcargoid,
                Bb032Cargo = dto.Bb032Cargo,
                Bb032Isactive = true
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB032 ToDtoGet(this CSICP_Bb032 entity)
        {
            return new Dto_GetBB032
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb032Codgcargoid = entity.Bb032Codgcargoid,
                Bb032Cargo = entity.Bb032Cargo,
                Bb032Isactive = entity.Bb032Isactive
            };
        }
    }
}



