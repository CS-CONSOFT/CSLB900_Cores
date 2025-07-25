using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF142
{
    public int TenantId { get; set; }

    public long Ff142Id { get; set; }

    public long? Ff140RdId { get; set; }

    public string? Ff102Id { get; set; }

    public string? Cc040Id { get; set; }

    public virtual CSICP_FF102? Ff102 { get; set; }

    public virtual CSICP_FF140? Ff140Rd { get; set; }
}
