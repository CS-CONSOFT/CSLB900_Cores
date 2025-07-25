using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD128
{
    public int TenantId { get; set; }

    public string Dd128Id { get; set; } = null!;

    public string? Dd042Id { get; set; }

    public string? Dd072Id { get; set; }

    public string? Pd014Id { get; set; }

    public string? Dd125Id { get; set; }

    public string? Key { get; set; }

    public virtual CSICP_DD042? Dd042 { get; set; }

    public virtual CSICP_DD072? Dd072 { get; set; }

    public virtual CSICP_DD125? Dd125 { get; set; }
}
