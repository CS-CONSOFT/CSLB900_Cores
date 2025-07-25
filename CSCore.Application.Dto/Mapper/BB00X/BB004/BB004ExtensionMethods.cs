using CSBS101._82Application.Dto.BB00X.BB004;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.BB00X.BB004
{
    public static class BB004ExtensionMethods
    {
        public static CSICP_BB004 ToEntity(this Dto_CreateUpdateBB004 dto)
        {
            var entity = new CSICP_BB004
            {
                Bb004Codigo = dto.Bb004Codigo,
                Bb004Datacambio = dto.Bb004Datacambio,
                Bb004Valorcambio = dto.Bb004Valorcambio,
                Moedaid = dto.Moedaid
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
        public static Dto_GetBB004 ToDtoGet(this CSICP_BB004 entity)
        {
            return new Dto_GetBB004
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb004Codigo = entity.Bb004Codigo,
                Bb004Datacambio = entity.Bb004Datacambio,
                Bb004Valorcambio = entity.Bb004Valorcambio,
                Moedaid = entity.Moedaid
            };
        }
    }
}
