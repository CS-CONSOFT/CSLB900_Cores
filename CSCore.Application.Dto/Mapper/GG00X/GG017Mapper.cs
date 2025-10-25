using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG017;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG017Mapper
    {
        public static DtoGetGG017 ToDtoGet(this CSICP_GG017 entity)
        {
            return new DtoGetGG017
            {
                TenantId = entity.TenantId,
                Gg017Id = entity.Gg017Id,
                Gg017Desccategoria = entity.Gg017Desccategoria,
                Gg017Nivel = entity.Gg017Nivel,
                Gg017CategoriapaiId = entity.Gg017CategoriapaiId,
                NavGg017Categoriapai = entity.NavGg017Categoriapai,
            };
        }
    }
}
