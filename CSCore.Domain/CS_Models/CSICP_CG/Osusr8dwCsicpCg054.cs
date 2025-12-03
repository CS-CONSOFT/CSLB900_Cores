using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg054
{
    public int TenantId { get; set; }

    public long Cg054Id { get; set; }

    [ForeignKey("NavCG050TipoEvento_CG054")]
    public long? Cg054Eventotpid { get; set; }

    [ForeignKey("NavCG055ValorEvento_CG054")]
    public long? Cg054Valortpid { get; set; }

    public Osusr8dwCsicpCg050? NavCG050TipoEvento_CG054 { get; set; }
    public Osusr8dwCsicpCg055? NavCG055ValorEvento_CG054 { get; set; }
}
