using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD273Xml
{
    public int TenantId { get; set; }

    public string Dd270Id { get; set; } = null!;

    public string? Dd273Tipo { get; set; }

    public byte[]? Dd273Xml { get; set; }

    public virtual CSICP_DD270 Dd270 { get; set; } = null!;
}
