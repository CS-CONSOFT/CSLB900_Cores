using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD911
{
    public int TenantId { get; set; }

    public long Dd911Id { get; set; }

    public string? Dd040Id { get; set; }

    public bool? Dd911Iserro { get; set; }

    public string? Dd911Mensagem { get; set; }

    public DateTime? Dd911Datahorainc { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }
}
