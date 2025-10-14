using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG009;

namespace FF105Financeiro.C82Application.Mapper
{
    public static class GG009Mapper
    {
        public static DtoGetGG009 ToDtoGet(this CSICP_GG009 entity)
        {
            return new DtoGetGG009
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg009Filial = entity.Gg009Filial,
                Gg009Filiald = entity.Gg009Filiald,
                Gg009Codigopadrao = entity.Gg009Codigopadrao,
                Gg009Descpadrao = entity.Gg009Descpadrao,
                Gg009IsActive = entity.Gg009IsActive,
                NavFilialBB001 = entity.NavFilialBB001,
            };
        }

        public static DtoGetGG009Simples ToDtoGetSimples(this CSICP_GG009 entity)
        {
            return new DtoGetGG009Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg009Filial = entity.Gg009Filial,
                Gg009Filiald = entity.Gg009Filiald,
                Gg009Codigopadrao = entity.Gg009Codigopadrao,
                Gg009Descpadrao = entity.Gg009Descpadrao,
                Gg009IsActive = entity.Gg009IsActive,
                
            };
        }
    }
}
