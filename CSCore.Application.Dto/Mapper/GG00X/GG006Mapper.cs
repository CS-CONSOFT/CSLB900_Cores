using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG006;
using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Dto.GG00X.GG006;

namespace GG104Materiais.C82Application.Mapper
{
    public static class GG006Mapper
    {
        public static DtoGetGG006 ToDtoGet(this CSICP_GG006 entity)
        {
            return new DtoGetGG006
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg006Filial = entity.Gg006Filial,
                Gg006Codgfilial = entity.Gg006Codgfilial,
                Gg006Codigomarca = entity.Gg006Codigomarca,
                Gg006Descmarca = entity.Gg006Descmarca,
                Gg006IsActive = entity.Gg006IsActive,
            };
        }

        public static DtoGetGG006Simples ToDtoGetSimples(this CSICP_GG006 entity)
        {
            return new DtoGetGG006Simples
            {
                Id = entity.Id,
                Gg006Codigomarca = entity.Gg006Codigomarca,
                Gg006Descmarca = entity.Gg006Descmarca,
            };
        }
    }
}
