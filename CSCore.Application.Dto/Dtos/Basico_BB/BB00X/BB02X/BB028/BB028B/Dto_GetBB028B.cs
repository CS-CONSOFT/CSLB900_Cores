using CSBS101._82Application.Dto.BB00X.BB012.Get;

namespace CSBS101._82Application.Dto.BB00X.BB028.BB028B
{
    public class Dto_GetBB028B
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb028bFilial { get; set; }

        public int? Bb028bCodresponsavel { get; set; }

        public int? Bb028bCodigocliente { get; set; }

        public decimal? Bb028bPerccomissao { get; set; }

        public string? Bb028bCompradorId { get; set; }

        public string? Bb028bContaid { get; set; }

        public Dto_GetBB012Simples? NavCSICP_BB012 { get; set; }

        //public CSICP_Bb028? NavBb028bComprador { get; set; }
    }
}
