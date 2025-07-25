using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD054
{
    public int TenantId { get; set; }

    public long Dd054Id { get; set; }

    public long? Dd053Id { get; set; }

    public byte[]? Objeto { get; set; }

    public virtual CSICP_DD053? Dd053 { get; set; }
}
