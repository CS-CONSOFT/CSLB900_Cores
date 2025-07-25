using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD007
{
    public int TenantId { get; set; }

    public string Dd007Id { get; set; } = null!;

    public string? Dd006Id { get; set; }

    public string? Dd007FormapagtoId { get; set; }

    public string? Dd007CondicaoId { get; set; }

    public decimal? Dd007Acimadeqtde { get; set; }

    public virtual CSICP_DD006? Dd006 { get; set; }
}
