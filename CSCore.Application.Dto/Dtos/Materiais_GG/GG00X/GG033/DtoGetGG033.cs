using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG033
{
    public class DtoGetGG033
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

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

        public DtoGetGG520SimplesComProdutoSemKardex? NavGG033_Saldo { get; set; }
        public Dto_GetBB001Simples? NavBB001Simples { get; set; }
    }
}