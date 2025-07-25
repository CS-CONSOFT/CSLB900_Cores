using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD138
{
    public int TenantId { get; set; }

    public long Dd13Id { get; set; }

    public long? Dd137Id { get; set; }

    public string? Dd138Produtoid { get; set; }

    public decimal? Dd138Vincentivo { get; set; }

    public virtual CSICP_DD137? Dd137 { get; set; }
}
