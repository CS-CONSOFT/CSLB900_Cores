

using CSBS101._82Application.Dto.BB00X.BB010;
using CSBS101._82Application.Dto.BB00X.BB01X.BB010;
using CSBS101._82Application.Mapper.BB00X;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB010ExtensionMethods
    {
        public static CSICP_Bb010 ToEntity(this Dto_CreateUpdateBB010 dto)
        {
            var entity = new CSICP_Bb010
            {
                Bb010Codigo = dto.Bb010Codigo,
                Bb010Zona = dto.Bb010Zona,
                Bb010CodVendedor = dto.Bb010CodVendedor,
                Bb010ColPrecoTabela = dto.Bb010ColPrecoTabela,
                Bb010Banco01Id = dto.Bb010Banco01Id,
                Bb010Banco02Id = dto.Bb010Banco02Id,
                Bb010Banco03Id = dto.Bb010Banco03Id,
                Bb010CcustoId = dto.Bb010CcustoId,
                Bb010Km = dto.Bb010Km,
                Bb010FoneContato = dto.Bb010FoneContato,
                Bb010Promotor = dto.Bb010Promotor,
                Bb010Observacao = dto.Bb010Observacao,
                Bb010PeriodoRota = dto.Bb010PeriodoRota,
                Bb010PeriodoVisita = dto.Bb010PeriodoVisita,
                Bb010TabelaPreco = dto.Bb010TabelaPreco,
                Bb010Vendedorid = dto.Bb010Vendedorid,
                Bb010Isactive = true,
                Bb010Tiporotaid = dto.Bb010Tiporotaid,
                Bb010Cidadeid = dto.Bb010Cidadeid,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB010 ToDtoGet(this CSICP_Bb010 entity)
        {
            return new Dto_GetBB010
            {
                Id = entity.Id,
                TenantId = entity.TenantId,
                Bb010Codigo = entity.Bb010Codigo,
                Bb010Zona = entity.Bb010Zona,
                Bb010CodVendedor = entity.Bb010CodVendedor,
                Bb010ColPrecoTabela = entity.Bb010ColPrecoTabela,
                NavBb010Banco01 = entity.Bb010Banco01?.ToDtoGet(),
                NavBb010Banco02 = entity.Bb010Banco02?.ToDtoGet(),
                NavBb010Banco03 = entity.Bb010Banco03?.ToDtoGet(),
                Bb010Banco01Id = entity.Bb010Banco01Id,
                Bb010Banco02Id = entity.Bb010Banco02Id,
                Bb010Banco03Id = entity.Bb010Banco03Id,
                Bb010CcustoId = entity.Bb010CcustoId,
                Bb010Km = entity.Bb010Km,
                Bb010FoneContato = entity.Bb010FoneContato,
                Bb010Promotor = entity.Bb010Promotor,
                Bb010Observacao = entity.Bb010Observacao,
                Bb010PeriodoRota = entity.Bb010PeriodoRota,
                Bb010PeriodoVisita = entity.Bb010PeriodoVisita,
                Bb010TabelaPreco = entity.Bb010TabelaPreco,
                Bb010Vendedorid = entity.Bb010Vendedorid,
                Bb010Isactive = entity.Bb010Isactive,
                Bb010Tiporotaid = entity.Bb010Tiporotaid,
                Bb010Cidadeid = entity.Bb010Cidadeid,
                NavBb010Ccusto = entity.Bb010Ccusto?.ToDtoGet(),
                NavBb010Vendedor = entity.Bb010Vendedor?.ToDtoGet(),
            };
        }

        public static Dto_GetBB010_Zona_Exibicao ToDtoGetSimples(this CSICP_Bb010 entity)
        {
            return new Dto_GetBB010_Zona_Exibicao
            {
                Id = entity.Id,
                TenantId = entity.TenantId,
                Bb010Codigo = entity.Bb010Codigo,
                Bb010Zona = entity.Bb010Zona,
                Bb010Banco01 = entity.Bb010Banco01?.ToDtoGetExibicao(),
                Bb010Banco02 = entity.Bb010Banco02?.ToDtoGetExibicao(),
                Bb010Banco03 = entity.Bb010Banco03?.ToDtoGetExibicao(),

            };
        }
    }
}
