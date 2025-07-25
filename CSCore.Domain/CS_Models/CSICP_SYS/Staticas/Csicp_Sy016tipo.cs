using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class Csicp_Sy016tipo
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public ICollection<Csicp_Sy016> OsusrE9aCsicpSy016s { get; set; } = new List<Csicp_Sy016>();
}
