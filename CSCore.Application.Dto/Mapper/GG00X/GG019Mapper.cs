using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG019;

namespace FF105Financeiro.C82Application.Mapper
{
    public static class GG019Mapper
    {
        public static DtoGetGG019 ToDtoGet(this CSICP_GG019 entity)
        {
            return new DtoGetGG019
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg019Filialid = entity.Gg019Filialid,
                Gg019CodigoBarras = entity.Gg019CodigoBarras,
                Gg019Produtoid = entity.Gg019Produtoid,
                Gg019Filial = entity.Gg019Filial,
                Gg019Item = entity.Gg019Item,
                Gg019Unidade = entity.Gg019Unidade,
                Gg019Unid = entity.Gg019Unid,
                Gg019FatorConversao = entity.Gg019FatorConversao,
                Gg019Lote = entity.Gg019Lote,
                Gg019SubLote = entity.Gg019SubLote,
                Gg019CodigoLinha = entity.Gg019CodigoLinha,
                Gg019CodigoColuna = entity.Gg019CodigoColuna,
                Gg019TipocbarraId = entity.Gg019TipocbarraId,
                Gg019ConversaoId = entity.Gg019ConversaoId,
                Gg019Codbarrasalfa = entity.Gg019Codbarrasalfa,
                Gg019KeysldId = entity.Gg019KeysldId,
                Gg019Isimpetq = entity.Gg019Isimpetq,
                NavGG08Conversao = entity.NavGG08Conversao,
                NavGg019Tipocbarra = entity.NavGg019Tipocbarra,
                NavGg007Un = entity.NavGg007Un?.ToDtoGetSimples(),
            };
        }
    }
}
