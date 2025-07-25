using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Dto.GG00X.GG001;

namespace GG104Materiais.C82Application.Mapper
{
    public static class GG001Mapper
    {

        public static DtoGetGG001 ToDtoGet(this CSICP_GG001 entity)
        {
            return new DtoGetGG001
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg001Filial = entity.Gg001Filial,
                Gg001Filialid = entity.Gg001Filialid,
                Gg001Codigoalmox = entity.Gg001Codigoalmox,
                Gg001Descalmox = entity.Gg001Descalmox,
                Gg001Isactive = entity.Gg001Isactive,
                Gg001Tipoalmoxarifado = entity.Gg001Tipoalmoxarifado,
                Gg001RiControlequalidade = entity.Gg001RiControlequalidade,
                Gg001Caparmaz = entity.Gg001Caparmaz,
                Gg001Descnspadrao = entity.Gg001Descnspadrao,
                Gg001TipoalmoxarifadoNavigation = entity.Gg001TipoalmoxarifadoNavigation,
            };
        }

        public static DtoGetGG001Simples ToDtoGetSimples(this CSICP_GG001 entity)
        {
            return new DtoGetGG001Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg001Filial = entity.Gg001Filial,
                Gg001Filialid = entity.Gg001Filialid,
                Gg001Codigoalmox = entity.Gg001Codigoalmox,
                Gg001Descalmox = entity.Gg001Descalmox,
                Gg001Isactive = entity.Gg001Isactive,
                Gg001Tipoalmoxarifado = entity.Gg001Tipoalmoxarifado,
                Gg001RiControlequalidade = entity.Gg001RiControlequalidade,
                Gg001Caparmaz = entity.Gg001Caparmaz,
                Gg001Descnspadrao = entity.Gg001Descnspadrao,

            };
        }

        public static DtoGetGG001SimplesComFilial ToDtoGetSimplesComFilial(this CSICP_GG001 entity)
        {
            return new DtoGetGG001SimplesComFilial
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg001Filial = entity.Gg001Filial,
                Gg001Filialid = entity.Gg001Filialid,
                Gg001Codigoalmox = entity.Gg001Codigoalmox,
                Gg001Descalmox = entity.Gg001Descalmox,
                Gg001Isactive = entity.Gg001Isactive,
                Gg001Tipoalmoxarifado = entity.Gg001Tipoalmoxarifado,
                Gg001RiControlequalidade = entity.Gg001RiControlequalidade,
                Gg001Caparmaz = entity.Gg001Caparmaz,
                Gg001Descnspadrao = entity.Gg001Descnspadrao,
                NavBB001 = entity.BB001FilialNav?.ToDtoGetExibicao()
            };
        }
    }
}



