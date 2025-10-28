using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg005
{
    public int TenantId { get; set; }

    public string Cg005Id { get; set; } = null!;

    public string? Cg005FilialId { get; set; }

    public int? Cg005Codigo { get; set; }

    public string? Cg005Historicoresumido { get; set; }

    public string? Cg005Historico { get; set; }

    public bool? Cg005Isactive { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg006> Osusr8dwCsicpCg006s { get; set; } = new List<Osusr8dwCsicpCg006>();

    public virtual ICollection<Osusr8dwCsicpCg016> Osusr8dwCsicpCg016s { get; set; } = new List<Osusr8dwCsicpCg016>();

    public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062Histcreds { get; set; } = new List<Osusr8dwCsicpCg062>();

    public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062Histdebs { get; set; } = new List<Osusr8dwCsicpCg062>();
}
