using CSCore.Domain.CS_Models.CSICP_NN;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.Staticas.NN;

public partial class OsusrE9aCsicpNn002Tpgru
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<OsusrE9aCsicpNn002> OsusrE9aCsicpNn002s { get; set; } = new List<OsusrE9aCsicpNn002>();
}
