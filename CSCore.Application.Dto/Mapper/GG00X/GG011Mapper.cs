using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG011;

namespace FF105Financeiro.C82Application.Mapper
{
    public static class GG011Mapper
    {
        public static DtoGetGG011 ToDtoGet(this CSICP_GG011 entity)
        {
            return new DtoGetGG011
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg011Filial = entity.Gg011Filial,
                Gg011Filialid = entity.Gg011Filialid,
                Gg011CodigoQualidade = entity.Gg011CodigoQualidade,
                Gg011Descricaoqualidade = entity.Gg011Descricaoqualidade,
                Gg011IsActive = entity.Gg011IsActive,
                NavFilial = entity.NavFilial,
            };
        }

        public static DtoGetGG011Simples ToDtoGetSimples(this CSICP_GG011 entity)
        {
            return new DtoGetGG011Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg011Filial = entity.Gg011Filial,
                Gg011Filialid = entity.Gg011Filialid,
                Gg011CodigoQualidade = entity.Gg011CodigoQualidade,
                Gg011Descricaoqualidade = entity.Gg011Descricaoqualidade,
                Gg011IsActive = entity.Gg011IsActive,
                
            };
        }
    }
}
