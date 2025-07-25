using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD052
{
    public int TenantId { get; set; }

    public string Dd052Id { get; set; } = null!;

    public string? Dd040Id { get; set; }

    public byte[]? Dd052Objeto { get; set; }

    public int? Dd052TobjetoId { get; set; }

    public string? Dd052Text { get; set; }

    public string? Dd052Xml { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD052Tp? Dd052Tobjeto { get; set; }
}
