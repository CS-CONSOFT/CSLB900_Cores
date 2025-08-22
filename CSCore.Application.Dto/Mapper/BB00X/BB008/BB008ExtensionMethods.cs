

using CSBS101._82Application.Dto.BB00X.BB008;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.Mapper.BB00X
{
    public static class BB008ExtensionMethods
    {
        public static CSICP_Bb008 ToEntity(this Dto_CreateUpdateBB008 dto)
        {
            var entity = new CSICP_Bb008
            {
                Empresaid = dto.Empresaid,
                Bb008Filial = dto.Bb008Filial,
                Bb008Codigo = dto.Bb008Codigo,
                Bb008CondicaoPagto = dto.Bb008CondicaoPagto,
                Bb008Tipo = dto.Bb008Tipo,
                Bb008Condicao = dto.Bb008Condicao,
                Bb008Codformapagto = dto.Bb008Codformapagto,
                Bb008Vlrmaxformapagto = dto.Bb008Vlrmaxformapagto,
                Bb008Vlrminformapagto = dto.Bb008Vlrminformapagto,
                Bb008Entliquidada = dto.Bb008Entliquidada,
                Bb008Parcliquidadas = dto.Bb008Parcliquidadas,
                Bb008AprovaVenda = dto.Bb008AprovaVenda,
                Bb008PercAcrescimo = dto.Bb008PercAcrescimo,
                Bb008PercDesconto = dto.Bb008PercDesconto,
                Bb008Indprecovenda = dto.Bb008Indprecovenda,
                Bb008Percentrada = dto.Bb008Percentrada,
                Bb008Valoracrescimo = dto.Bb008Valoracrescimo,
                Bb008Fatorjuros = dto.Bb008Fatorjuros,
                Bb008Isactive = true,
                Bb008Tipoid = dto.Bb008Tipoid,
                Bb008Qtdparcela = dto.Bb008Qtdparcela
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB008 ToDtoGet(this CSICP_Bb008 entity)
        {
            return new Dto_GetBB008
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Empresaid = entity.Empresaid,
                Bb008Filial = entity.Bb008Filial,
                Bb008Codigo = entity.Bb008Codigo,
                Bb008CondicaoPagto = entity.Bb008CondicaoPagto,
                Bb008Tipo = entity.Bb008Tipo,
                Bb008Condicao = entity.Bb008Condicao,
                Bb008Codformapagto = entity.Bb008Codformapagto,
                Bb008Vlrmaxformapagto = entity.Bb008Vlrmaxformapagto,
                Bb008Vlrminformapagto = entity.Bb008Vlrminformapagto,
                Bb008Entliquidada = entity.Bb008Entliquidada,
                Bb008Parcliquidadas = entity.Bb008Parcliquidadas,
                Bb008AprovaVenda = entity.Bb008AprovaVenda,
                Bb008PercAcrescimo = entity.Bb008PercAcrescimo,
                Bb008PercDesconto = entity.Bb008PercDesconto,
                Bb008Indprecovenda = entity.Bb008Indprecovenda,
                Bb008Percentrada = entity.Bb008Percentrada,
                Bb008Valoracrescimo = entity.Bb008Valoracrescimo,
                Bb008Fatorjuros = entity.Bb008Fatorjuros,
                Bb008Isactive = entity.Bb008Isactive,
                Bb008Tipoid = entity.Bb008Tipoid,
                Bb008Qtdparcela = entity.Bb008Qtdparcela,
                NavBB008_Aprova_Venda = entity.NavBB008_Aprova_Venda,
                NavBB008_EntLiquidada = entity.NavBB008_EntLiquidada,
                NavBB008_ParcLiquidadas = entity.NavBB008_ParcLiquidadas,
                NavBb008Tipo = entity.CSICP_Bb008Tipo,
                NavBB001Excibicao = entity.CSICP_BB001?.ToDtoGetSimples(),
            };
        }

        public static Dto_GetBB008_Exibicao ToDtoGetSimples(this CSICP_Bb008 entity)
        {
            return new Dto_GetBB008_Exibicao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb008Codigo = entity.Bb008Codigo,
                Bb008CondicaoPagto = entity.Bb008CondicaoPagto,
                //Bb008Tipo = entity.Bb008Tipo,
                //Bb008Condicao = entity.Bb008Condicao,
                //Bb008Codformapagto = entity.Bb008Codformapagto,

            };
        }

        /// <summary>
        /// Método de extensão para mapear a entidade para o Dto_GetBB008DentroFatores que é usada quando há referenciado DTOBB008 para ele MESMO
        /// Ele nao funcionava quando tinha referencia dentro de si a nivel de swaager, a referencia de dentro vinha como string
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static Dto_GetBB008SemFatoresList ToDtoGetSemFatores(this CSICP_Bb008 entity)
        {
            return new Dto_GetBB008SemFatoresList
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Empresaid = entity.Empresaid,
                Bb008Filial = entity.Bb008Filial,
                Bb008Codigo = entity.Bb008Codigo,
                Bb008CondicaoPagto = entity.Bb008CondicaoPagto,
                Bb008Tipo = entity.Bb008Tipo,
                Bb008Condicao = entity.Bb008Condicao,
                Bb008Codformapagto = entity.Bb008Codformapagto,
                Bb008Vlrmaxformapagto = entity.Bb008Vlrmaxformapagto,
                Bb008Vlrminformapagto = entity.Bb008Vlrminformapagto,
                Bb008Entliquidada = entity.Bb008Entliquidada,
                Bb008Parcliquidadas = entity.Bb008Parcliquidadas,
                Bb008AprovaVenda = entity.Bb008AprovaVenda,
                Bb008PercAcrescimo = entity.Bb008PercAcrescimo,
                Bb008PercDesconto = entity.Bb008PercDesconto,
                Bb008Indprecovenda = entity.Bb008Indprecovenda,
                Bb008Percentrada = entity.Bb008Percentrada,
                Bb008Valoracrescimo = entity.Bb008Valoracrescimo,
                Bb008Fatorjuros = entity.Bb008Fatorjuros,
                Bb008Isactive = entity.Bb008Isactive,
                Bb008Tipoid = entity.Bb008Tipoid,
                Bb008Qtdparcela = entity.Bb008Qtdparcela
            };
        }
    }
}
