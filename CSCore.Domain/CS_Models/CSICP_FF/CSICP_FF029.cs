using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF029
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff028Cupomid { get; set; }

    public DateTime? Ff029Impressoem { get; set; }

    public string? Ff029Impressopor { get; set; }

    public virtual CSICP_FF028? Ff028Cupom { get; set; }
}
