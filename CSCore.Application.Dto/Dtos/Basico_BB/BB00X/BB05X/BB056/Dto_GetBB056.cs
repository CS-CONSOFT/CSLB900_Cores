using CSBS101._82Application.Dto.BB00X.BB012.Get;

namespace CSBS101._82Application.Dto.BB00X.BB05X.BB056
{
    public class Dto_GetBB056
    {
        public int TenantId { get; set; }

        public long Bb056Id { get; set; }

        public string? Bb056Profid { get; set; }

        public string? Bb056Contaid { get; set; }

        public string? Bb056Mensagem { get; set; }

        public decimal? Bb056Rate { get; set; }

        public DateTime? Bb056Datahora { get; set; }

        public bool? Bb056Isactive { get; set; }

        public bool? Bb056Issmsenviadoprof { get; set; }

        public bool? Bb056Issmsenviadocliente { get; set; }

        public DateTime? Bb056Dtsmsprof { get; set; }

        public DateTime? Bb056Dtsmscliente { get; set; }

        public Dto_GetBB012Simples? NavBB012 { get; set; }
    }
}
