using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr009
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Rr001Id { get; set; }

    public string? Rr001Virtualid { get; set; }
}
