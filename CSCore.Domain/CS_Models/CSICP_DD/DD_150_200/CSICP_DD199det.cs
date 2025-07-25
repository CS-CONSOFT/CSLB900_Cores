using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD199det
{
    public int TenantId { get; set; }

    public long Dd199dId { get; set; }

    public long? Dd199Id { get; set; }

    public string? Dd199dMotivoid { get; set; }

    public decimal? Dd199Qtd { get; set; }

    public long? Gg074Id { get; set; }

    public virtual CSICP_DD199? Dd199 { get; set; }
}
