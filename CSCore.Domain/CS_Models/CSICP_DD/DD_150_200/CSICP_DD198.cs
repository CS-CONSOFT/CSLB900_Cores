using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD198
{
    public int TenantId { get; set; }

    public long Dd198Id { get; set; }

    public long? Dd190Obraid { get; set; }

    public string? Dd198Nomecontato { get; set; }

    public string? Dd198Email { get; set; }

    public string? Dd198Celular { get; set; }

    public string? Dd198Celular2 { get; set; }

    public string? Dd198Cargo { get; set; }

    public virtual CSICP_DD190? Dd190Obra { get; set; }
}
