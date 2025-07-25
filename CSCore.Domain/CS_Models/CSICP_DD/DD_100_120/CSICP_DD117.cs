using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD117
{
    public int TenantId { get; set; }

    public string Dd117Id { get; set; } = null!;

    public string? Dd110Id { get; set; }

    public byte[]? Dd117Objeto { get; set; }

    public int? Dd117TobjetoId { get; set; }

    public string? Dd117Xml { get; set; }

    public virtual CSICP_DD110? Dd110 { get; set; }

    public virtual CSICP_DD052Tp? Dd117Tobjeto { get; set; }
}
