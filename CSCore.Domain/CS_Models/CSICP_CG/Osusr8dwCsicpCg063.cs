using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg063
{
    public int TenantId { get; set; }

    public long Cg063Id { get; set; }

    [ForeignKey("NavCG060RegramentoID_CG063")]
    public long? Cg063Regramentoid { get; set; }

    [ForeignKey("NavCG051PrmEvento_CG063")]
    public string? Cg063Parametroid { get; set; }

    public long? Cg063Eventopartpid { get; set; }
    
    public Osusr8dwCsicpCg051? NavCG051PrmEvento_CG063 { get; set; }

    public Osusr8dwCsicpCg060? NavCG060RegramentoID_CG063 { get; set; }
}
