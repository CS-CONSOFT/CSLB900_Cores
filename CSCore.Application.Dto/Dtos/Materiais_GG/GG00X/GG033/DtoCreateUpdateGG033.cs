using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG033
{
    public class DtoCreateUpdateGG033 : IConverteParaEntidade<CSICP_GG033>
    {
        public string? Gg033Filialid { get; set; }

        public string? Gg032Id { get; set; }

        public string? Gg033Saldoid { get; set; }

        public int? Gg033Produto { get; set; }

        public decimal? Gg033Codigobarras { get; set; }

        public DateTime? Gg033Datareferente { get; set; }

        public decimal? Gg033Qtdinventario { get; set; }

        public decimal? Gg033Saldoestoque { get; set; }

        public decimal? Gg033Qtdajuste { get; set; }

        public string? Gg033Entsai { get; set; }

        public decimal? Gg033Precocusto { get; set; }

        public decimal? Gg033Precocustoreal { get; set; }

        public decimal? Gg033Precocustomedio { get; set; }

        public decimal? Gg033Precovenda { get; set; }

        public DateTime? Gg033Datafechanterior { get; set; }

        public decimal? Gg033Qtdfechanterior { get; set; }

        public bool? Gg033Naoinventariar { get; set; }

        public bool? Gg033Alterado { get; set; }

        public string? Gg033NnGrupoId { get; set; }

        public string? Gg033NnClasseId { get; set; }

        public string? Gg033NnMarcaId { get; set; }

        public string? Gg033NnArtigoId { get; set; }

        public string? Gg033NnLinhaId { get; set; }

        public string? Gg033NnSubgrupoId { get; set; }

        public string? Gg033QuemdigitouUserId { get; set; }

        public string? Gg033QuemcontouUserid { get; set; }

        public int? Gg033Posicao { get; set; }

        public string? Gg033Codbarrasalfa { get; set; }
        public CSICP_GG033 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG033
            {
                TenantId = tenant,
                Id = id!,
                Gg033Filialid = this.Gg033Filialid,
                Gg032Id = this.Gg032Id,
                Gg033Saldoid = this.Gg033Saldoid,
                Gg033Produto = this.Gg033Produto,
                Gg033Codigobarras = this.Gg033Codigobarras,
                Gg033Datareferente = this.Gg033Datareferente,
                Gg033Qtdinventario = this.Gg033Qtdinventario,
                Gg033Saldoestoque = this.Gg033Saldoestoque,
                Gg033Qtdajuste = this.Gg033Qtdajuste,
                Gg033Entsai = this.Gg033Entsai,
                Gg033Precocusto = this.Gg033Precocusto,
                Gg033Precocustoreal = this.Gg033Precocustoreal,
                Gg033Precocustomedio = this.Gg033Precocustomedio,
                Gg033Precovenda = this.Gg033Precovenda,
                Gg033Datafechanterior = this.Gg033Datafechanterior,
                Gg033Qtdfechanterior = this.Gg033Qtdfechanterior,
                Gg033Naoinventariar = this.Gg033Naoinventariar,
                Gg033Alterado = this.Gg033Alterado,
                Gg033NnGrupoId = this.Gg033NnGrupoId,
                Gg033NnClasseId = this.Gg033NnClasseId,
                Gg033NnMarcaId = this.Gg033NnMarcaId,
                Gg033NnArtigoId = this.Gg033NnArtigoId,
                Gg033NnLinhaId = this.Gg033NnLinhaId,
                Gg033NnSubgrupoId = this.Gg033NnSubgrupoId,
                Gg033QuemdigitouUserId = this.Gg033QuemdigitouUserId,
                Gg033QuemcontouUserid = this.Gg033QuemcontouUserid,
                Gg033Posicao = this.Gg033Posicao,
                Gg033Codbarrasalfa = this.Gg033Codbarrasalfa,
            };
        }
    }
}
