using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF007
{
    public int TenantId { get; set; }

    public long Ff007Id { get; set; }

    public string? Ff007Estabid { get; set; }

    public int? Ff007Diasate { get; set; }

    public decimal? Ff007Pdesconto { get; set; }
    public CSICP_BB001? NavBB001 { get; set; }

}
