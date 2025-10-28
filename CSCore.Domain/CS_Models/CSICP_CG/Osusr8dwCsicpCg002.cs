using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg002
{
    public int TenantId { get; set; }

    public string Cg002Id { get; set; } = null!;

    public string? Cg002FilialId { get; set; }

    public string? Cg002Nivel { get; set; }

    public string? Cg002Descricao { get; set; }

    public string? Cg002Descricaoresumida { get; set; }

    public int? Cg002Controlasaldo { get; set; }

    //public virtual ICollection<Osusr8dwCsicpCg011> Osusr8dwCsicpCg011s { get; set; } = new List<Osusr8dwCsicpCg011>();
}
