using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD141
{
    public int TenantId { get; set; }

    public long Dd141Id { get; set; }

    public string? Gg008Id { get; set; }

    public decimal? Dd141Psvliquida { get; set; }

    public decimal? Dd141Vunvendida { get; set; }
}
