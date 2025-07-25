using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD017
{
    public int TenantId { get; set; }

    public string Dd017Id { get; set; } = null!;

    public string? Dd017Descricao { get; set; }

    public bool? Dd017Isactive { get; set; }

    public string? Dd017Codigo { get; set; }
}
