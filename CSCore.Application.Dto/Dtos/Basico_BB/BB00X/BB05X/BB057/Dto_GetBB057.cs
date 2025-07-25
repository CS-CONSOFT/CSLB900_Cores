using CSBS101._82Application.Dto.BB00X.BB012.Get;

namespace CSBS101._82Application.Dto.BB00X.BB05X.BB057
{
    public class Dto_GetBB057
    {
        public int TenantId { get; set; }

        public long Bb057Id { get; set; }

        public string? Bb055Id { get; set; }

        public string? Bb012Id { get; set; }

        public DateTime? Bb057Datahora { get; set; }

        public bool? Bb057Issmsenvprof { get; set; }

        public bool? Bb057Issmsenvcliente { get; set; }

        public DateTime? Bb057Dtsmsprof { get; set; }

        public DateTime? Bb057Dtsmscliente { get; set; }
        public Dto_GetBB012Simples? NavBB012 { get; set; }
    }
}
