using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD183
{
    public int TenantId { get; set; }

    public string Dd183Id { get; set; } = null!;

    public long? Dd181Id { get; set; }

    public string? Dd040Id { get; set; }

    public string? Dd183Protocolodocorigem { get; set; }

    public string? Cd070Id { get; set; }

    public string? Dd110Id { get; set; }

    public string? Gg041Id { get; set; }

    public long? Gg071Id { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD110? Dd110 { get; set; }

    public virtual CSICP_DD181? Dd181 { get; set; }
}
