
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Aa042
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Aa042Id { get; set; }

    public string? Ufid { get; set; }

    public string? Aa042Produtoid { get; set; }

    public int? Aa042CfopId { get; set; }

    public int? Aa042CstOrigemid { get; set; }

    public int? Aa042CstId { get; set; }

    public long? Aa042Coddeclaid { get; set; }

    public Osusr66cSpedInCfop? Aa042Cfop { get; set; }

    public CSICP_Aa041? Aa042Coddecla { get; set; }

    public CSICP_AA032Csticm? Aa042Cst { get; set; }

    public CSICP_AA031Cstori? Aa042CstOrigem { get; set; }

    public CSICP_Aa027? Uf { get; set; }
}
