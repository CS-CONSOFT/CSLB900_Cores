using CSBS101._82Application.Dto.AA00X;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.AA00X.AA025
{
    public static class AA025ExtensionMethods
    {
        public static Dto_GetAA025 ToDtoGet(this CSICP_Aa025 entity)
        {
            return new Dto_GetAA025
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Aa025Codigobacen = entity.Aa025Codigobacen,
                Aa025CodigoNacoesunidas = entity.Aa025CodigoNacoesunidas,
                Aa025Codigopais = entity.Aa025Codigopais,
                Aa025Codigosiscomex = entity.Aa025Codigosiscomex,
                Aa025Isactive = entity.Aa025Isactive,
                Aa025Nacionalidade = entity.Aa025Nacionalidade,
                Aa025Iso3166A2 = entity.Aa025Iso3166A2,
                Aa025Iso3166A3 = entity.Aa025Iso3166A3,
                Aa025Iso3166N3 = entity.Aa025Iso3166N3,
                Aa025ExportPaisid = entity.Aa025ExportPaisid,
                Aa025Descricao = entity.Aa025Descricao
            };
        }


        //Dto Create to Entity
        public static CSICP_Aa025 ToEntity(this Dto_CreateUpdateAA025 dto)
        {
            var entity = new CSICP_Aa025()
            {
                Aa025Codigobacen = dto.Aa025Codigobacen,
                Aa025CodigoNacoesunidas = dto.Aa025CodigoNacoesunidas,
                Aa025Codigopais = dto.Aa025Codigopais,
                Aa025Codigosiscomex = dto.Aa025Codigosiscomex,
                Aa025Isactive = true,
                Aa025Nacionalidade = dto.Aa025Nacionalidade,
                Aa025Iso3166A2 = dto.Aa025Iso3166A2,
                Aa025Iso3166A3 = dto.Aa025Iso3166A3,
                Aa025Iso3166N3 = dto.Aa025Iso3166N3,
                Aa025ExportPaisid = dto.Aa025ExportPaisid,
                Aa025Descricao = dto.Aa025Descricao
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}
