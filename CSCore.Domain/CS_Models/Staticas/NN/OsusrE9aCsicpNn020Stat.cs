using CSCore.Domain.CS_Models.CSICP_NN;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.Staticas.NN;

public partial class OsusrE9aCsicpNn020Stat
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<OsusrE9aCsicpNn020> OsusrE9aCsicpNn020s { get; set; } = new List<OsusrE9aCsicpNn020>();
}
