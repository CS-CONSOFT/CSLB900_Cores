using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD161
{
    public int TenantId { get; set; }

    public long Dd161Id { get; set; }

    public string? Dd161EstabId { get; set; }

    public string? Dd161Descambiente { get; set; }

    public string? Dd161Descdetalhada { get; set; }

    public string? Dd161Usuarioid { get; set; }

    public DateTime? Dd161Dcriacao { get; set; }
}
