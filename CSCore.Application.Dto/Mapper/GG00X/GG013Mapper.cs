using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG013;

namespace FF105Financeiro.C82Application.Mapper
{
    public static class GG013Mapper
    {
        public static DtoGetGG013 ToDtoGet(this CSICP_GG013 entity)
        {
            return new DtoGetGG013
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg013Filial = entity.Gg013Filial,
                Gg013Filialid = entity.Gg013Filialid,
                Gg013Aplicacao = entity.Gg013Aplicacao,

            };
        }
    }
}

