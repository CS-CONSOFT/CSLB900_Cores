using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD013
{
    public int TenantId { get; set; }

    public string Dd013Id { get; set; } = null!;

    [ForeignKey("NavBB001FilialID_DD013")]
    public string? Dd013Empresaid { get; set; }

    public string? Dd013Texto { get; set; }

    public string? Dd013Protocolnumber { get; set; }

    public CSICP_BB001? NavBB001FilialID_DD013 { get; set; }
}
