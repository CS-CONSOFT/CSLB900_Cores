using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class CSICP_AA031Cstori
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public string? CstDigito { get; set; }

    //public  ICollection<CSICP_Aa042> OsusrE9aCsicpAa042s { get; set; } = new List<CSICP_Aa042>();
}
