using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD910
{
    public int TenantId { get; set; }

    public long Dd910Id { get; set; }

    public string? Dd070Id { get; set; }

    public string? Dd040Id { get; set; }

    public bool? Dd910Iserro { get; set; }

    public string? Dd910Mensagem { get; set; }

    public int? Dd910Statusid { get; set; }

    public DateTime? Dd910Datahorainc { get; set; }

    public string? Dd910Json { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }

    public virtual CSICP_DD910St? Dd910Status { get; set; }
}
