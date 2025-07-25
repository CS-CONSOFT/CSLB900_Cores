using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD070W
{
    public int TenantId { get; set; }

    public string Dd070Id { get; set; } = null!;

    public int? Dd070StatId { get; set; }

    public string? Dd070ControleId { get; set; }

    public string? Dd070Protocolnumber { get; set; }

    public virtual CSICP_DD070 Dd070 { get; set; } = null!;

    public virtual CSICP_DD070Wsstat? Dd070Stat { get; set; }
}
