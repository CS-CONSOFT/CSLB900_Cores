using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Dto.GG00X.GG010;

namespace GG104Materiais.C82Application.Mapper
{
    public static class GG010Mapper
    {
        public static DtoGetGG010 ToDtoGet(this CSICP_GG010 entity)
        {
            return new DtoGetGG010()
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg010Filial = entity.Gg010Filial,
                Gg010Filialid = entity.Gg010Filialid,
                Gg010CodigoTipopadrao = entity.Gg010CodigoTipopadrao,
                Gg010Descricaotipopadrao = entity.Gg010Descricaotipopadrao,
                Gg010IsActive = entity.Gg010IsActive,
                NavFilial = entity.NavFilial?.ToDtoGetSimples()
            };
        }

        public static DtoGetGG010Simples ToDtoGetSimples(this CSICP_GG010 entity)
        {
            return new DtoGetGG010Simples()
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg010Filial = entity.Gg010Filial,
                Gg010Filialid = entity.Gg010Filialid,
                Gg010CodigoTipopadrao = entity.Gg010CodigoTipopadrao,
                Gg010Descricaotipopadrao = entity.Gg010Descricaotipopadrao,
                Gg010IsActive = entity.Gg010IsActive,
                //NavFilial = entity.NavFilial?.ToDtoGet()
            };
        }
    }
}
