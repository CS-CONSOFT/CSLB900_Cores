using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class OsusrE9aCsicpNn018
{
    public int TenantId { get; set; }

    public string Nn018Id { get; set; } = null!;

    public string? Nn010Id { get; set; }

    public string? Nn015Id { get; set; }

    public string? Nn010TransfId { get; set; }

    public string? Nn010Protocolnumber { get; set; }

    public string? Nn015Protocolnumber { get; set; }

    public virtual OsusrE9aCsicpNn010? Nn010 { get; set; }

    public virtual CSICP_NN015? Nn015 { get; set; }
}
