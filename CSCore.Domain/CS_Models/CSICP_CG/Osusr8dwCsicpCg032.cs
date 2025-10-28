using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg032
{
    public int TenantId { get; set; }

    public string Cg032Id { get; set; } = null!;

    public string? Cg031Id { get; set; }

    public string? Cg032Contadre { get; set; }

    public string? Cg032Descricao { get; set; }

    public decimal? Cg032Vinformado { get; set; }

    public int? Cg032Qcaractercodigo { get; set; }

    public virtual Osusr8dwCsicpCg031? Cg031 { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg033> Osusr8dwCsicpCg033s { get; set; } = new List<Osusr8dwCsicpCg033>();

    public virtual ICollection<Osusr8dwCsicpCg034> Osusr8dwCsicpCg034s { get; set; } = new List<Osusr8dwCsicpCg034>();

    public virtual ICollection<Osusr8dwCsicpCg038> Osusr8dwCsicpCg038s { get; set; } = new List<Osusr8dwCsicpCg038>();
}
