using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD070040
{
    public int TenantId { get; set; }

    public string Dd070LinkId { get; set; } = null!;

    public string? Dd070Id { get; set; }

    public string? Dd040Id { get; set; }

    public string? Pd010Id { get; set; }
}
