using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD085json
{
    public int TenantId { get; set; }

    public long Dd085jsId { get; set; }

    public string? Dd085Aprovacaodecreditoid { get; set; }

    public string? Dd085jsJson { get; set; }

    public virtual CSICP_DD085? Dd085Aprovacaodecredito { get; set; }
}
