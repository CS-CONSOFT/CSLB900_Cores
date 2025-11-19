using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg004
{
    public int TenantId { get; set; }

    public string Cg004Id { get; set; } = null!;

    public string? Cg004FilialId { get; set; }

    public int? Cg004Codigo { get; set; }

    public string? Cg004Descricao { get; set; }

    public int? Cg004TipoId { get; set; }

    public bool? Cg004Isactive { get; set; }
}
