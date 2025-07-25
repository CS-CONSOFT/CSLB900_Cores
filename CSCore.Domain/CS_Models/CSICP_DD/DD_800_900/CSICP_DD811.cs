using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD811
{
    public int TenantId { get; set; }

    public string Dd811Id { get; set; } = null!;

    public int? Dd811CfopId { get; set; }

    public int? Dd811CstIcmsId { get; set; }

    public int? Dd811CstPisId { get; set; }

    public int? Dd811CstCofinsId { get; set; }

    public int? Dd811CstIpiId { get; set; }

    public string? Dd811Anotacao { get; set; }

    public string? Dd811Hashid { get; set; }
}
