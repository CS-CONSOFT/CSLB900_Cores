using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD111
{
    public int TenantId { get; set; }

    public string Dd111Id { get; set; } = null!;

    public string? Dd111Descricao { get; set; }

    public string? Dd111Codigo { get; set; }

    public int? Dd111TpdespesaId { get; set; }

    public virtual CSICP_DD111Tde? Dd111Tpdespesa { get; set; }
}
