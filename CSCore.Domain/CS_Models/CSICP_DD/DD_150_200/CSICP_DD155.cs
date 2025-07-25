using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD155
{
    public int TenantId { get; set; }

    public string Dd155Id { get; set; } = null!;

    public string? Dd155Estabid { get; set; }

    public int? Dd155Qhoraspadrao { get; set; }

    public int? Dd155Qhorasmax { get; set; }

    public decimal? Dd155Peficiencia { get; set; }

    public long? Dd155Perfilprincid { get; set; }

    public virtual CSICP_DD160? Dd155Perfilprinc { get; set; }
}
