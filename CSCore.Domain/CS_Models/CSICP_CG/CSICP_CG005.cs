using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class CSICP_CG005
{
    public int TenantId { get; set; }

    public string Cg005Id { get; set; } = null!;

    [ForeignKey("NavBB001_CG005")]
    public string? Cg005FilialId { get; set; }

    public int? Cg005Codigo { get; set; }

    public string? Cg005Historicoresumido { get; set; }

    public string? Cg005Historico { get; set; }

    public bool? Cg005Isactive { get; set; }

    public CSICP_BB001? NavBB001_CG005 { get; set; }
}
