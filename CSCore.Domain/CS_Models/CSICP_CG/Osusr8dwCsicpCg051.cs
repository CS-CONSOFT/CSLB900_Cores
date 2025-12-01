using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg051
{
    public int TenantId { get; set; }

    public long Cg051Id { get; set; }

    [ForeignKey("NavCG050TipoEvento_CG051")]
    public long? Cg051Eventotpid { get; set; }

    [ForeignKey("NavCG052PrmEvento_CG051")]
    public long? Cg051Parametrotpid { get; set; }

    public bool? Flobrigatorio { get; set; }

    public Osusr8dwCsicpCg050? NavCG050TipoEvento_CG051 { get; set; }

    public Osusr8dwCsicpCg052? NavCG052PrmEvento_CG051 { get; set; }
}
