using CSBS101._82Application.Dto.BB00X.BB029;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB029ExtensionMethods
    {
        public static CSICP_Bb029 ToEntity(this Dto_CreateUpdateBB029 dto)
        {
            var entity = new CSICP_Bb029
            {
                Bb029Codgcategoria = dto.Bb029Codgcategoria,
                Bb029Categoria = dto.Bb029Categoria,
                Bb029IsActive = true
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB029 ToDtoGet(this CSICP_Bb029 entity)
        {
            return new Dto_GetBB029
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb029Codgcategoria = entity.Bb029Codgcategoria,
                Bb029Categoria = entity.Bb029Categoria,
                Bb029IsActive = entity.Bb029IsActive
            };
        }
    }
}
