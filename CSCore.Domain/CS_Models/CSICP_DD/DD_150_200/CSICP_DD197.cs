using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD197
{
    public int TenantId { get; set; }

    public long Dd197Id { get; set; }

    public long? Dd190Obraid { get; set; }

    public DateTime? Dd197Data { get; set; }

    public DateTime? Dd197Hora { get; set; }

    public string? Dd197Usuario { get; set; }

    public string? Dd197Mensagem { get; set; }

    public virtual CSICP_DD190? Dd190Obra { get; set; }
}
