using CSCore.Domain;



namespace CSBS101._82Application.Dto.BB00X.BB012.Get.BB012M
{
    public class Dto_GetBB012M
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Bb012Id { get; set; }

        public string? Bb012Contatoid { get; set; }

        public string? Bb012Candidatoid { get; set; }

        public string? Bb043Campanhaid { get; set; }

        public string? Bb042Potencialid { get; set; }

        public string? Bb040Atividadeid { get; set; }

        public string? Bb041Casoid { get; set; }

        public int? Bb012mCodigoCliente { get; set; }

        public string? Bb012mDescricao { get; set; }

        public byte[]? Bb012mContent { get; set; }

        public string? Bb012mFiletype { get; set; }

        public string? Bb012mFilename { get; set; }

        public bool? Bb012mIsActive { get; set; }

        public int? Bb012mTipodoctoid { get; set; }

        public int? Bb012mDoctoid { get; set; }

        public DateTime? Bb012mDatadocto { get; set; }

        public string? Bb012mPath { get; set; }

        public Csicp_Bb012mdc? NavBB012MDC { get; set; }
        public Csicp_Bb012mtd? NavBB012MTD { get; set; }
    }
}
