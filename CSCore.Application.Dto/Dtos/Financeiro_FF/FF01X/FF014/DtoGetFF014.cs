using CSBS101._82Application.Dto.BB00X.BB001;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF014
{
    public class DtoGetFF014
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;
        public string? Ff014Filialid { get; set; }
        public int? Ff014Handle { get; set; }
        public string? Ff014Descricao { get; set; }
        public string? Ff014Comissaoid { get; set; }
        public int? Ff014Diasde { get; set; }
        public int? Ff014Diasate { get; set; }
        public decimal? Ff014Perccomissao { get; set; }

        public Dto_GetBB001_Exibicao? NavBB001 { get; set; }
        public DtoGetFF014Simples? NavFF014ComissaoFilho { get; set; }
    }

    public class DtoGetFF014Simples
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;
        public string? Ff014Filialid { get; set; }
        public int? Ff014Handle { get; set; }
        public string? Ff014Descricao { get; set; }
        public string? Ff014Comissaoid { get; set; }
        public int? Ff014Diasde { get; set; }
        public int? Ff014Diasate { get; set; }
        public decimal? Ff014Perccomissao { get; set; }
    }
}