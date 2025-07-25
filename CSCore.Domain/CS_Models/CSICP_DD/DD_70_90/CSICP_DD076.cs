using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD076
{
    public int TenantId { get; set; }

    public string Dd076Id { get; set; } = null!;

    public string? Dd070Id { get; set; }

    public string? Dd076NumProcesso { get; set; }

    public int? Dd076OrigemProcesso { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }

    public virtual CSICP_DD046Pro? Dd076OrigemProcessoNavigation { get; set; }
}
