using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg050
{
    public int TenantId { get; set; }

    public long Cg050Id { get; set; }

    public string? Cg050Txcodigo { get; set; }

    public string? Cg050Txdescricao { get; set; }

    public int? Cg050Periodicidadeid { get; set; }

    public int? Cg050Moduloid { get; set; }

    public bool? Cg050Flonline { get; set; }

    public bool? Cg050Flencerramento { get; set; }

    public bool? Cg050Flperman { get; set; }

    public bool? Cg050Flperexc { get; set; }

    public bool? Cg050Isactive { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg051> Osusr8dwCsicpCg051s { get; set; } = new List<Osusr8dwCsicpCg051>();

    public virtual ICollection<Osusr8dwCsicpCg054> Osusr8dwCsicpCg054s { get; set; } = new List<Osusr8dwCsicpCg054>();

    public virtual ICollection<Osusr8dwCsicpCg060> Osusr8dwCsicpCg060Cg060Eventos { get; set; } = new List<Osusr8dwCsicpCg060>();

    public virtual ICollection<Osusr8dwCsicpCg060> Osusr8dwCsicpCg060Cg060Eventotpcreds { get; set; } = new List<Osusr8dwCsicpCg060>();

    public virtual ICollection<Osusr8dwCsicpCg060> Osusr8dwCsicpCg060Cg060Eventotpdebs { get; set; } = new List<Osusr8dwCsicpCg060>();

    public virtual ICollection<Osusr8dwCsicpCg064> Osusr8dwCsicpCg064s { get; set; } = new List<Osusr8dwCsicpCg064>();

    public virtual ICollection<Osusr8dwCsicpCg071> Osusr8dwCsicpCg071s { get; set; } = new List<Osusr8dwCsicpCg071>();
}
