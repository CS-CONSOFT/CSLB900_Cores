using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD808
{
    public int TenantId { get; set; }

    public long Dd808Id { get; set; }

    public long? Dd807Id { get; set; }

    public string? Dd808Corpo { get; set; }

    public int? Dd808Numcolunas { get; set; }

    public virtual CSICP_DD807? Dd807 { get; set; }
}
