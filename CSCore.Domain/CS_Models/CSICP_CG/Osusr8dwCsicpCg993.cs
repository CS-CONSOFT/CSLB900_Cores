using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg993
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public string? Resumido1 { get; set; }

    public string? Resumido2 { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg016> Osusr8dwCsicpCg016s { get; set; } = new List<Osusr8dwCsicpCg016>();

    public virtual ICollection<Osusr8dwCsicpCg021> Osusr8dwCsicpCg021s { get; set; } = new List<Osusr8dwCsicpCg021>();

    public virtual ICollection<Osusr8dwCsicpCg074> Osusr8dwCsicpCg074s { get; set; } = new List<Osusr8dwCsicpCg074>();

    public virtual ICollection<Osusr8dwCsicpCg081> Osusr8dwCsicpCg081s { get; set; } = new List<Osusr8dwCsicpCg081>();
}
