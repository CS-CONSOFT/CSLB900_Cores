using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr011
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Rr011Serie { get; set; }

    public int? Rr011Ultrgn { get; set; }
}
