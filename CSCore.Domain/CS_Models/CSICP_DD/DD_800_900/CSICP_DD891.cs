using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD891
{
    public int TenantId { get; set; }

    public string Dd891Id { get; set; } = null!;

    public string? Dd891EstabelecimentoId { get; set; }

    public int? Dd891Tiporeg { get; set; }

    public string? Dd040Id { get; set; }

    public string? Cc040Id { get; set; }

    public DateTime? Dd891Data { get; set; }

    public int? Dd891Statid { get; set; }

    public string? Dd891Msgerro { get; set; }

    public string? Dd891Usuariopropid { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD891Stat? Dd891Stat { get; set; }
}
