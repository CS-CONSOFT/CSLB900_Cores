using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg055
{
    public int TenantId { get; set; }

    public long Cg055Id { get; set; }

    public string? Cg055Txcodigo { get; set; }

    public string? Cg055Txdescricao { get; set; }

    public int? Cg055Moduloid { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg054> Osusr8dwCsicpCg054s { get; set; } = new List<Osusr8dwCsicpCg054>();
}
