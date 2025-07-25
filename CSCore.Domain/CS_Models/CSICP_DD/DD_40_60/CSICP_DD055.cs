using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD055
{
    public int TenantId { get; set; }

    public long Dd055Id { get; set; }

    public string? Dd040Id { get; set; }

    public int? Dd055Tipo { get; set; }

    public DateTime? Dd055Dh { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }
}
