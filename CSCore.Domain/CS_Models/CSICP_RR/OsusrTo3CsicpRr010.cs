using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr010
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string Rr010Condcriacao { get; set; } = string.Empty;

    public string Rr010Descritivo { get; set; } = string.Empty;
}
