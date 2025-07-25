
using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class CSICP_Aa030Tptoken
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    //public ICollection<CSICP_AA030> OsusrE9aCsicpAa030Tokens { get; set; } = new List<CSICP_AA030>();
}
