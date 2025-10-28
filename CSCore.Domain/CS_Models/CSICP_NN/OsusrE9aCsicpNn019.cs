using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class OsusrE9aCsicpNn019
{
    public int TenantId { get; set; }

    public string Nn019Id { get; set; } = null!;

    public string? Nn015BaixaCrcpId { get; set; }

    public string? Nn015EstornoId { get; set; }

    public int? Nn015Protocolnumber { get; set; }

    public decimal? Nn015Protocoloestorno { get; set; }

    public string? Nn015PnEstorno { get; set; }

    public string? Nn015Protocolonumber { get; set; }

    public virtual CSICP_NN015? Nn015Estorno { get; set; }
}
