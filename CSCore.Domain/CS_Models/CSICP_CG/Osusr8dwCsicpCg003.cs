using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg003
{
    public int TenantId { get; set; }

    public string Cg003Id { get; set; } = null!;

    public string? Cg003FilialId { get; set; }

    public int? Cg003Codigo { get; set; }

    public string? Cg003Descricao { get; set; }

    public int? Cg003Natureza { get; set; }

    public bool? Cg003Isactive { get; set; }

    public virtual Osusr8dwCsicpCg999? Cg003NaturezaNavigation { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg006> Osusr8dwCsicpCg006s { get; set; } = new List<Osusr8dwCsicpCg006>();

    public virtual ICollection<Osusr8dwCsicpCg011> Osusr8dwCsicpCg011s { get; set; } = new List<Osusr8dwCsicpCg011>();
}
