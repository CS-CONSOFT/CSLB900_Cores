using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD151
{
    public int TenantId { get; set; }

    public int Dd151Id { get; set; }

    public int? Dd150Id { get; set; }

    public string? Dd060Id { get; set; }

    public string? Gg008Id { get; set; }

    public decimal? Dd151Qmontagem { get; set; }

    public decimal? Dd151LogTfaturliq { get; set; }

    public decimal? Dd151LogPsobrefaturliq { get; set; }

    public decimal? Dd151LogPmontador { get; set; }

    public int? Dd156Regramontgid { get; set; }

    public virtual CSICP_DD060? Dd060 { get; set; }

    public virtual CSICP_DD150? Dd150 { get; set; }

    public virtual CSICP_DD156Rg? Dd156Regramontg { get; set; }
}
