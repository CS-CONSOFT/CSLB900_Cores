using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD162
{
    public int TenantId { get; set; }

    public string Dd162Id { get; set; } = null!;

    public string? Dd162EstabId { get; set; }

    public string? Dd162Descricao { get; set; }

    public string? Dd162Descdetalhada { get; set; }

    public bool? Dd162Isactive { get; set; }

    public long? Dd162Ambienteid { get; set; }
}
