using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD089
{
    public int TenantId { get; set; }

    public long Dd089Id { get; set; }

    public string? Dd080Id { get; set; }

    public decimal? Dd089Quantidade { get; set; }

    public string? Dd089ItemReId { get; set; }

    public string? Dd089StabId { get; set; }

    public string? Dd089KdxId { get; set; }

    public virtual CSICP_DD080? Dd080 { get; set; }
}
