
using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class OsusrNnxSpedInTabela
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public string? Codgcs { get; set; }

    //public ICollection<CSICP_Aa041> OsusrE9aCsicpAa041s { get; set; } = new List<CSICP_Aa041>();
}
