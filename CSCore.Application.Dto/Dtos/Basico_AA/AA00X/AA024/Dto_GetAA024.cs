using CSBS101._82Application.Dto.AA00X;

namespace CSBS101.C82Application.Dto.AA00X.AA024
{
    public class Dto_GetAA024
    {
        public int TenantId { get; set; }

        public long Id { get; set; }

        public string? Aa024NomeUdh { get; set; }

        public string? Aa028Id { get; set; }

        public decimal? Aa024IdhmR { get; set; }

        public string? Aa024Ano { get; set; }

        public string? Aa027Id { get; set; }
        public Dto_GetAA028? NavAA028 { get; set; }
    }
}
