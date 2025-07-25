using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class CSICP_BB001Capmun
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    // public  ICollection<CSICP_BB001Global> OsusrE9aCsicpBb001Globals { get; set; } = new List<CSICP_BB001Global>();

    //  public  ICollection<CSICP_BB001> OsusrE9aCsicpBb001s { get; set; } = new List<CSICP_BB001>();
}
