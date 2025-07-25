using CSBS101._82Application.Dto.BB00X;
using CSBS101._82Application.Dto.BB00X.BB021;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB021ExtensionMethods
    {
        public static CSICP_Bb021 ToEntity(this Dto_CreateUpdateBB021 dto)
        {
            var entity = new CSICP_Bb021
            {
                Bb021Filial = dto.Bb021Filial,
                Bb021DataEmissao = dto.Bb021DataEmissao,
                Bb021Autorizacao = dto.Bb021Autorizacao,
                Bb021Hora = dto.Bb021Hora,
                Bb021Codautorizador = dto.Bb021Codautorizador,
                Bb021NomeAutorizador = dto.Bb021NomeAutorizador,
                Bb021Situacao = dto.Bb021Situacao,
                Bb021Modulo = dto.Bb021Modulo,
                Bb021Tipo = dto.Bb021Tipo,
                Bb021PercentualValor = dto.Bb021PercentualValor,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB021 ToDtoGet(this CSICP_Bb021 entity)
        {
            return new Dto_GetBB021
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb021Filial = entity.Bb021Filial,
                Bb021DataEmissao = entity.Bb021DataEmissao,
                Bb021Autorizacao = entity.Bb021Autorizacao,
                Bb021Hora = entity.Bb021Hora,
                Bb021Codautorizador = entity.Bb021Codautorizador,
                Bb021NomeAutorizador = entity.Bb021NomeAutorizador,
                Bb021Situacao = entity.Bb021Situacao,
                Bb021Modulo = entity.Bb021Modulo,
                Bb021Tipo = entity.Bb021Tipo,
                Bb021PercentualValor = entity.Bb021PercentualValor,
                Bb021Codautorizado = entity.Bb021Codautorizado,
                Bb021NomeAutorizado = entity.Bb021NomeAutorizado,
                Bb021CodigoProduto = entity.Bb021CodigoProduto
            };
        }

        public static CSICP_Bb021a ToEntity(this Dto_CreateUpdateBB021A dto)
        {
            return new CSICP_Bb021a
            {
                Bb021aFilial = dto.Bb021aFilial,
                Bb021aCiOrigem = dto.Bb021aCiOrigem,
                Bb021aCiOrigemSeq = dto.Bb021aCiOrigemSeq,
                Bb021aNoestacao = dto.Bb021aNoestacao,
                Bb021aTabela = dto.Bb021aTabela,
                Bb021aNoautorizacao = dto.Bb021aNoautorizacao,
                Bb021aDataemissao = dto.Bb021aDataemissao
            };
        }

        public static Dto_GetBB021A ToDtoGet(this CSICP_Bb021a entity)
        {
            return new Dto_GetBB021A
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb021aFilial = entity.Bb021aFilial,
                Bb021aCiOrigem = entity.Bb021aCiOrigem,
                Bb021aCiOrigemSeq = entity.Bb021aCiOrigemSeq,
                Bb021aNoestacao = entity.Bb021aNoestacao,
                Bb021aTabela = entity.Bb021aTabela,
                Bb021aNoautorizacao = entity.Bb021aNoautorizacao,
                Bb021aDataemissao = entity.Bb021aDataemissao
            };
        }
    }
}
