using CSBS101._82Application.Dto.BB00X.BB013;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB013ExtensionMethods
    {
        public static CSICP_Bb013 ToEntity(this Dto_CreateUpdateBB013 dto)
        {
            var entity = new CSICP_Bb013
            {
                Bb013Codigo = dto.Bb013Codigo,
                Bb013Bairro = dto.Bb013Bairro,
                Bb013Codgcidade = dto.Bb013Codgcidade
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB013 ToDtoGet(this CSICP_Bb013 entity)
        {
            return new Dto_GetBB013
            {
                Id = entity.Id,
                TenantId = entity.TenantId,
                Bb013Codigo = entity.Bb013Codigo,
                Bb013Bairro = entity.Bb013Bairro,
                Bb013Codgcidade = entity.Bb013Codgcidade
            };
        }
    }
}
