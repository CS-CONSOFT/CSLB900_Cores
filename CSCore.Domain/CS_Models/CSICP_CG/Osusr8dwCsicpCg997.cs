using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg997
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg006> Osusr8dwCsicpCg006s { get; set; } = new List<Osusr8dwCsicpCg006>();

    public virtual ICollection<Osusr8dwCsicpCg011> Osusr8dwCsicpCg011s { get; set; } = new List<Osusr8dwCsicpCg011>();

    public virtual ICollection<Osusr8dwCsicpCg081> Osusr8dwCsicpCg081s { get; set; } = new List<Osusr8dwCsicpCg081>();
}
