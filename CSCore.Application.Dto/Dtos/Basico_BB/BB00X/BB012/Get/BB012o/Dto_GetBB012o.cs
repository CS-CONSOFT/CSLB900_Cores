using CSCore.Domain;

namespace CSBS101._82Application.Dto.BB00X.BB012.Get.RetencaoImpostos
{
    public class Dto_GetBB012o
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Bb012Id { get; set; }

        public int? Bb012oCodigo { get; set; }

        public int? Bb012oRetem { get; set; }

        public decimal? Bb012oPercentual { get; set; }

        public int? Bb012oImpostoId { get; set; }
        public CSICP_AA037Imp? NavBb012oImposto { get; set; }
        public CSICP_Statica? NavStatica_Retem { get; set; }
    }
}
