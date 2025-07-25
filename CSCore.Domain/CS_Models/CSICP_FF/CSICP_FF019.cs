using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF019
{
    public int TenantId { get; set; }

    public long Ff019Id { get; set; }

    public string? Ff000Id { get; set; }

    public string? Ff019FpagtoId { get; set; }

    public string? Ff019Condicaoid { get; set; }

    public virtual CSICP_FF000? Ff000 { get; set; }
}
