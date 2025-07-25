using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF028
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff024Id { get; set; }

    public string? Ff028Contaid { get; set; }

    public DateTime? Ff028Geradoem { get; set; }

    public bool? Ff028Impresso { get; set; }

    public bool? Ff028Premiado { get; set; }

    public string? Ff028Usuariopropid { get; set; }

    public string? Ff102Id { get; set; }

    public string? Ff028Nrocupom { get; set; }

    public virtual CSICP_FF024? Ff024 { get; set; }

    public virtual CSICP_FF102? Ff102 { get; set; }
}
