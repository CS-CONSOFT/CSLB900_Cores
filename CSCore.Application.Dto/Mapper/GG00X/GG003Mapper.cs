using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG003;

namespace FF105Financeiro.C82Application.Mapper
{
    public static class GG003Mapper
    {
        public static DtoGetGG003 ToDtoGet(this CSICP_GG003 entity)
        {
            return new DtoGetGG003
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg003Filial = entity.Gg003Filial,
                Gg003Filialid = entity.Gg003Filialid,
                Gg003Codigogrupo = entity.Gg003Codigogrupo,
                Gg003Descgrupo = entity.Gg003Descgrupo,
                Gg003Plucro = entity.Gg003Plucro,
                Gg003Isactive = entity.Gg003Isactive,
                Gg003Isvisivelcompra = entity.Gg003Isvisivelcompra,
                Gg003Isvisivelvenda = entity.Gg003Isvisivelvenda,
                Gg003Ordemconsulta = entity.Gg003Ordemconsulta,
                Gg003Iconegrupoproduto = entity.Gg003Iconegrupoproduto,
                Gg003Isexibepdv = entity.Gg003Isexibepdv,
            };
        }

        public static DtoGetGG003_Exibicao_2 ToDtoGetSimples(this CSICP_GG003 entity)
        {
            return new DtoGetGG003_Exibicao_2
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg003Filial = entity.Gg003Filial,
                Gg003Filialid = entity.Gg003Filialid,
                Gg003Codigogrupo = entity.Gg003Codigogrupo,
                Gg003Descgrupo = entity.Gg003Descgrupo,
                Gg003Plucro = entity.Gg003Plucro,
                Gg003Isactive = entity.Gg003Isactive,
                Gg003Isvisivelcompra = entity.Gg003Isvisivelcompra,
                Gg003Isvisivelvenda = entity.Gg003Isvisivelvenda,
                Gg003Ordemconsulta = entity.Gg003Ordemconsulta,
                Gg003Iconegrupoproduto = entity.Gg003Iconegrupoproduto,
                Gg003Isexibepdv = entity.Gg003Isexibepdv,
            };
        }
    }
}

