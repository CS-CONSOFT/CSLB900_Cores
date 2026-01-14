using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD811
{
    public int TenantId { get; set; }

    public string Dd811Id { get; set; } = null!;

    [ForeignKey("NavSpedInCFOP_DD811")]
    public int? Dd811CfopId { get; set; }

    [ForeignKey("NavAA032Csticm_DD811")]
    public int? Dd811CstIcmsId { get; set; }

    [ForeignKey("NavAA033Cstpis_DD811")]
    public int? Dd811CstPisId { get; set; }

    [ForeignKey("NavAA034Cstcofins_DD811")]
    public int? Dd811CstCofinsId { get; set; }

    [ForeignKey("NavAA035Cstipi_DD811")]
    public int? Dd811CstIpiId { get; set; }

    public string? Dd811Anotacao { get; set; }

    public string? Dd811Hashid { get; set; }

    public Osusr66cSpedInCfop? NavSpedInCFOP_DD811 { get; set; }

    public CSICP_AA032Csticm? NavAA032Csticm_DD811 { get; set; }

    public CSICP_AA033Cstipi? NavAA033Cstpis_DD811 { get; set; }

    public CSICP_AA034Cstpi? NavAA034Cstcofins_DD811 { get; set; }

    public CSICP_AA035Cstcof? NavAA035Cstipi_DD811 { get; set; }

}
