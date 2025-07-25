using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class CSICP_Bb027Fdesen
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public ICollection<CSICP_Bb027Imp> OsusrE9aCsicpBb027Imps { get; set; } = new List<CSICP_Bb027Imp>();
}
