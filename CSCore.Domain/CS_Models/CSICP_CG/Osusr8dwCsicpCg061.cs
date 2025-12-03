using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg061
{
    public int TenantId { get; set; }

    public long Cg061Id { get; set; }

    [ForeignKey("NavCG060RegramentoID_CG061")]
    public long? Cg061Regramentoid { get; set; }

    [ForeignKey("NavBB001Estab_CG061")]
    public string? Cg061Estabid { get; set; }

    public Osusr8dwCsicpCg060? NavCG060RegramentoID_CG061 { get; set; }

    public CSICP_BB001? NavBB001Estab_CG061 { get; set; }
}
