using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG015;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG060
{
    public class DtoGetGG060ParaGG003
    {
        public int TenantId { get; set; }

        public int Gg060Id { get; set; }

        public string? Gg060EstabId { get; set; }

        public string? Gg060Grupoid { get; set; }

        public string? Gg060Subgrupoid { get; set; }

        public decimal? Gg060Plucro { get; set; }

        public bool? Gg060Isactive { get; set; }

        public DateTime? Gg060Dregistro { get; set; }

        public decimal? Gg060Pmaxdesconto { get; set; }

        public bool? Gg060Ispadrao { get; set; }
        public DtoGetGG015? Nav_Gg015Subgrupo { get; set; }
        public Dto_GetBB001Simples? Nav_FilialBB001 { get; set; }
    }

    public class DtoGetGG060ParaGG003SemFilial
    {
        public int TenantId { get; set; }

        public int Gg060Id { get; set; }

        public string? Gg060EstabId { get; set; }

        public string? Gg060Grupoid { get; set; }

        public string? Gg060Subgrupoid { get; set; }

        public decimal? Gg060Plucro { get; set; }

        public bool? Gg060Isactive { get; set; }

        public DateTime? Gg060Dregistro { get; set; }

        public decimal? Gg060Pmaxdesconto { get; set; }

        public bool? Gg060Ispadrao { get; set; }
        public DtoGetGG015? Nav_Gg015Subgrupo { get; set; }
    }
}
