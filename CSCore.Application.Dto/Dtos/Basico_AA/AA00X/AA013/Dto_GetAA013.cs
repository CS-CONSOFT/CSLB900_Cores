using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Domain;


namespace CSBS101._82Application.Dto.AA00X.AA013
{
    public class Dto_GetAA013
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public decimal? Aa013Filial { get; set; }

        public string? Aa013Serie { get; set; }

        public decimal? Aa013Numero { get; set; }

        public DateTime? Aa013DataValidade { get; set; }

        public string? Aa013Filialid { get; set; }

        public int? Aa013ModId { get; set; }

        public bool? Aa013Isusocontigencia { get; set; }


        public OsusrNnxSpedInDocIcm? NavAa013Mod { get; set; }

        public Dto_GetBB001Simples? NavFilial { get; set; }
    }

    public class Dto_GetAA013_Simples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public decimal? Aa013Filial { get; set; }

        public string? Aa013Serie { get; set; }

        public decimal? Aa013Numero { get; set; }

        public DateTime? Aa013DataValidade { get; set; }

        public string? Aa013Filialid { get; set; }

        public int? Aa013ModId { get; set; }

        public bool? Aa013Isusocontigencia { get; set; }
    }
}
