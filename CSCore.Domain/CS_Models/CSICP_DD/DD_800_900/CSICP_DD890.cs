using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD890
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? DocId { get; set; }

    public int? Tipoestatiscaid { get; set; }

    public virtual CSICP_DD800Tipo? Tipoestatisca { get; set; }
}
