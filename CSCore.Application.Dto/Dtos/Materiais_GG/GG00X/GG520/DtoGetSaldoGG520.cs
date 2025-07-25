using GG104Materiais.C82Application.Dto.GG00X.GG003;
using GG104Materiais.C82Application.Dto.GG00X.GG004;
using GG104Materiais.C82Application.Dto.GG00X.GG005;
using GG104Materiais.C82Application.Dto.GG00X.GG006;
using GG104Materiais.C82Application.Dto.GG00X.GG008;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG520
{
    public class DtoGetSaldoGG520
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public decimal? Gg520NsNumerosaldo { get; set; }

        public string? Gg520Descricaosaldo { get; set; }

        public int? Gg008Codgproduto { get; set; }

        public string? Gg008Descreduzida { get; set; }

        public DtoGetGG006? NavMarcaProdutoGG006 { get; set; }

        public DtoGetGG005? NavArtigoProdutoGG005 { get; set; }

        public DtoGetGG004? NavClasseProdutoGG004 { get; set; }

        public DtoGetGG003? NavGrupoProdutoGG003 { get; set; }

    }

    public class DtoGetSaldoGG520ParaGG45
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public decimal? Gg520NsNumerosaldo { get; set; }

        public string? Gg520Descricaosaldo { get; set; }

        public string? Gg520Descricaolote { get; set; }
        public decimal? Gg520Saldo { get; set; }

        public DtoGetGG008_Exibicao_Simples? NavGg008Produto { get; set; }
    }
}
