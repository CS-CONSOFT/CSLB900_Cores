using CSBS101._82Application.Dto.BB00X.BB013;
using CSCore.Domain.CS_Models.CSICP_BB.BB01X;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB015ExtensionMethods
    {
        public static CSICP_BB015 ToEntity(this Dto_CreateUpdateBB015 dto)
        {
            var entity = new CSICP_BB015
            {
                Bb015Acessomarketplace = dto.Bb015Acessomarketplace,
                Bb015Cnpj = dto.Bb015Cnpj,
                Bb015Marketplace = dto.Bb015Marketplace,
                Bb015Skid = dto.Bb015Skid,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB015 ToDtoGet(this CSICP_BB015 entity)
        {
            return new Dto_GetBB015
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb015Acessomarketplace = entity.Bb015Acessomarketplace,
                Bb015Cnpj = entity.Bb015Cnpj,
                Bb015Marketplace = entity.Bb015Marketplace,
                Bb015Skid = entity.Bb015Skid,
            };
        }
    }
}
