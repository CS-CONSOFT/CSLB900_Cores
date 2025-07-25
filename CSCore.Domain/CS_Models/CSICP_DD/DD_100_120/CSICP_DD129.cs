using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD129
{
    public int TenantId { get; set; }

    public long Dd129Id { get; set; }

    public string? Ff102Tituloid { get; set; }

    public decimal? Dd129Vtitulo { get; set; }

    public bool? Dd129Isprocessado { get; set; }

    public string? Dd126RegccredId { get; set; }

    public string? Dd040NotaId { get; set; }

    public virtual CSICP_DD040? Dd040Nota { get; set; }

    public virtual CSICP_DD126? Dd126Regccred { get; set; }
}
