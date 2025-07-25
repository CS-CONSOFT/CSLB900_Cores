using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;

namespace GG104Materiais.C82Application.Dto.GG00X.GG019
{
    public class DtoCreateUpdateGG019 : IConverteParaEntidade<CSICP_GG019>
    {
        public string? Gg019Filialid { get; set; }

        public decimal? Gg019CodigoBarras { get; set; }

        public string? Gg019Produtoid { get; set; }

        public int? Gg019Filial { get; set; }

        public int? Gg019Item { get; set; }

        public string? Gg019Unidade { get; set; }

        public string? Gg019Unid { get; set; }

        public decimal? Gg019FatorConversao { get; set; }

        public string? Gg019Lote { get; set; }

        public string? Gg019SubLote { get; set; }

        public string? Gg019CodigoLinha { get; set; }

        public string? Gg019CodigoColuna { get; set; }

        public int? Gg019TipocbarraId { get; set; }

        public int? Gg019ConversaoId { get; set; }

        public string? Gg019Codbarrasalfa { get; set; }

        public string? Gg019KeysldId { get; set; }

        public bool? Gg019Isimpetq { get; set; }

        public CSICP_GG019 ToEntity(int tenant, string? id)
        {
            var entity = new CSICP_GG019
            {
                Id = id!,
                TenantId = tenant,
                Gg019Filialid = this.Gg019Filialid,
                Gg019CodigoBarras = this.Gg019CodigoBarras,
                Gg019Produtoid = this.Gg019Produtoid,
                Gg019Filial = this.Gg019Filial,
                Gg019Item = this.Gg019Item,
                Gg019Unidade = this.Gg019Unidade,
                Gg019Unid = this.Gg019Unid,
                Gg019FatorConversao = this.Gg019FatorConversao,
                Gg019Lote = this.Gg019Lote,
                Gg019SubLote = this.Gg019SubLote,
                Gg019CodigoLinha = this.Gg019CodigoLinha,
                Gg019CodigoColuna = this.Gg019CodigoColuna,
                Gg019TipocbarraId = this.Gg019TipocbarraId,
                Gg019ConversaoId = this.Gg019ConversaoId,
                Gg019Codbarrasalfa = this.Gg019Codbarrasalfa,
                Gg019KeysldId = this.Gg019KeysldId,
                Gg019Isimpetq = this.Gg019Isimpetq,
            };
            return entity;
        }
    }
}
