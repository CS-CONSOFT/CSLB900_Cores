using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg050
{
    public int TenantId { get; set; }

    public long Cg050Id { get; set; }

    public string? Cg050Txcodigo { get; set; }

    public string? Cg050Txdescricao { get; set; }

    public int? Cg050Periodicidadeid { get; set; }

    public int? Cg050Moduloid { get; set; }

    public bool? Cg050Flonline { get; set; }

    public bool? Cg050Flencerramento { get; set; }

    public bool? Cg050Flperman { get; set; }

    public bool? Cg050Flperexc { get; set; }

    public bool? Cg050Isactive { get; set; }
}
