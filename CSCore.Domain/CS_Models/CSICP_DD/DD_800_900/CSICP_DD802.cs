using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD802
{
    public int TenantId { get; set; }

    public string Dd802Id { get; set; } = null!;

    public string? Dd801Id { get; set; }

    public string? Dd802KardexId { get; set; }

    public decimal? Dd802Precovenda { get; set; }

    public string? Dd802IdControle { get; set; }

    public DateTime? Dd802Createdate { get; set; }

    public int? Dd802Seqimpressao { get; set; }

    public virtual CSICP_DD801? Dd801 { get; set; }
}
