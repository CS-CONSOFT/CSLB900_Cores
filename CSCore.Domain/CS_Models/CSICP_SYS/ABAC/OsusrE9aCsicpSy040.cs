using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class OsusrE9aCsicpSy040
{
    public string Id { get; set; } = null!;

    public string? Fieldname { get; set; }

    public string? Displayname { get; set; }

    public string? Datatype { get; set; }

    public string? Controltype { get; set; }

    public string? Optionssource { get; set; }

    public bool? Isactive { get; set; }

    public virtual ICollection<OsusrE9aCsicpSy042> OsusrE9aCsicpSy042s { get; set; } = new List<OsusrE9aCsicpSy042>();

    public virtual ICollection<OsusrE9aCsicpSy043> OsusrE9aCsicpSy043s { get; set; } = new List<OsusrE9aCsicpSy043>();
}
