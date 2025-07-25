using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD114
{
    public int TenantId { get; set; }

    public long Dd114Id { get; set; }

    public string? Dd110Cargaid { get; set; }

    public int? Dd114Seq { get; set; }

    public string? Dd114Ufid { get; set; }

    public virtual CSICP_DD110? Dd110Carga { get; set; }
}
