using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD060comb
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Dd060Id { get; set; }

    public string? Indimport { get; set; }

    public string? Cuforig { get; set; }

    public decimal? Porig { get; set; }

    public virtual CSICP_DD060? Dd060 { get; set; }
}
