using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg008
{
    public int TenantId { get; set; }

    public string Cg008Id { get; set; } = null!;

    public int? Cg008Cod { get; set; }

    public string? Cg008Descricao { get; set; }

    public string? Cg008Descresumida { get; set; }

    public bool? Cg008Isactive { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg009> Osusr8dwCsicpCg009s { get; set; } = new List<Osusr8dwCsicpCg009>();

    public virtual ICollection<Osusr8dwCsicpCg010> Osusr8dwCsicpCg010s { get; set; } = new List<Osusr8dwCsicpCg010>();

    public virtual ICollection<Osusr8dwCsicpCg012> Osusr8dwCsicpCg012s { get; set; } = new List<Osusr8dwCsicpCg012>();

    public virtual ICollection<Osusr8dwCsicpCg013> Osusr8dwCsicpCg013s { get; set; } = new List<Osusr8dwCsicpCg013>();

    public virtual ICollection<Osusr8dwCsicpCg015> Osusr8dwCsicpCg015s { get; set; } = new List<Osusr8dwCsicpCg015>();

    public virtual ICollection<Osusr8dwCsicpCg020> Osusr8dwCsicpCg020s { get; set; } = new List<Osusr8dwCsicpCg020>();

    public virtual ICollection<Osusr8dwCsicpCg021> Osusr8dwCsicpCg021s { get; set; } = new List<Osusr8dwCsicpCg021>();

    public virtual ICollection<Osusr8dwCsicpCg031> Osusr8dwCsicpCg031s { get; set; } = new List<Osusr8dwCsicpCg031>();
}
