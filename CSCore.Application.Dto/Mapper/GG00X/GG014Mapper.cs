using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG014;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG014Mapper
    {
        public static DtoGetGG014 ToDtoGet(this CSICP_GG014 entity)
        {
            return new DtoGetGG014
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg014Filialid = entity.Gg014Filialid,
                Gg014Linha = entity.Gg014Linha,
                Gg014IsActive = entity.Gg014IsActive,
                NavFilialBB001 = entity.NavFilialBB001,
            };
        }

        public static DtoGetGG014Simples ToDtoGetSimples(this CSICP_GG014 entity)
        {
            return new DtoGetGG014Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg014Filialid = entity.Gg014Filialid,
                Gg014Linha = entity.Gg014Linha,
                Gg014IsActive = entity.Gg014IsActive,
                
            };
        }
    }
}
