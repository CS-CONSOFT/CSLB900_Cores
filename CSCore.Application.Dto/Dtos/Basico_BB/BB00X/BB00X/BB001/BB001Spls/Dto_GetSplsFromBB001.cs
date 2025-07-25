using CSCore.Domain;

namespace CSBS101._82Application.Dto.BB00X.BB001.BB001Spls
{
    public class Dto_GetSplsFromBB001
    {
        public int TenantId { get; set; }

        public string Bb001SimplesId { get; set; } = null!;

        public string? Bb001Id { get; set; }

        public int? Bb001SimplespartId { get; set; }

        public decimal? Bb001AliqSimples { get; set; }

        public decimal? Bb001AliqIrpj { get; set; }

        public decimal? Bb001AliqCsll { get; set; }

        public decimal? Bb001AliqCofins { get; set; }

        public decimal? Bb001AliqPisPasep { get; set; }

        public decimal? Bb001AliqCpp { get; set; }

        public decimal? Bb001AliqIcms { get; set; }

        public decimal? Bb001AliqIpi { get; set; }

        public decimal? Bb001AliqIss { get; set; }
        public CSICP_BB001_Aliqs? Bb001Simplespart { get; set; }
    }
}
