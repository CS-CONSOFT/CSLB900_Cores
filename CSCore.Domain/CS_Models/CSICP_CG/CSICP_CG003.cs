using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class CSICP_CG003
{
    public int TenantId { get; set; }

    public string Cg003Id { get; set; } = null!;

    [ForeignKey("NavBB001_CG003")]
    public string? Cg003FilialId { get; set; }

    public int? Cg003Codigo { get; set; }

    public string? Cg003Descricao { get; set; }

    public int? Cg003Natureza { get; set; }

    public bool? Cg003Isactive { get; set; }

    public CSICP_BB001? NavBB001_CG003 { get; set; }
}
