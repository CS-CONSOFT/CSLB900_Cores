using CSBS101._82Application.Dto.BB00X.BB037;
using CSCore.Domain;



namespace CSBS101._82Application.Dto.BB00X.BB06X.BB062
{
    public class Dto_GetBB062
    {
        public int TenantId { get; set; }

        public long Bb062Id { get; set; }

        public int? Bb062Ano { get; set; }

        public int? Bb062Mes { get; set; }

        public string? Bb062Descritivo { get; set; }

        public DateTime? Bb062Dtemissao { get; set; }

        public string? Bb062Diavenctoid { get; set; }

        public int? Bb062Statusid { get; set; }

        public string? Bb062Estabid { get; set; }

        public Dto_GetBB037? NavBb062Diavencto { get; set; }

        public CSICP_Bb062Stum? NavBb062Status { get; set; }
    }
}
