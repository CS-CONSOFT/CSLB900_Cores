using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD013
{
    public int TenantId { get; set; }

    public string Dd013Id { get; set; } = null!;

    public string? Dd013Empresaid { get; set; }

    public string? Dd013Texto { get; set; }

    public string? Dd013Protocolnumber { get; set; }
}
