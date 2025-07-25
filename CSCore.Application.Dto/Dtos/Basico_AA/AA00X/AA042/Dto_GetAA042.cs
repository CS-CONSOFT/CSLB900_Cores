

using CSCore.Domain;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_GetAA042
    {
        public int TenantId { get; set; }

        public long Aa042Id { get; set; }

        public string? Ufid { get; set; }

        public string? Aa042Produtoid { get; set; }

        public int? Aa042CfopId { get; set; }

        public int? Aa042CstOrigemid { get; set; }

        public int? Aa042CstId { get; set; }

        public long? Aa042Coddeclaid { get; set; }

        public Osusr66cSpedInCfop? NavAa042Cfop { get; set; }

        public Dto_GetAA041? NavAa042Coddecla { get; set; }

        public CSICP_AA032Csticm? NavAa042Cst { get; set; }

        public CSICP_AA031Cstori? NavAa042CstOrigem { get; set; }

        public Dto_GetAA027? NavUf { get; set; }
    }
}
