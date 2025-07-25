using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF130
{
    public int TenantId { get; set; }

    public string Ff130Id { get; set; } = null!;

    public string? Ff130Descricao { get; set; }

    public DateTime? Ff130Dtinicio { get; set; }

    public DateTime? Ff130Dtfinal { get; set; }

    public bool? Ff130Isactive { get; set; }
}
