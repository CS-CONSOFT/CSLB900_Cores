using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class OsusrE9aCsicpSy035
{
    public int? TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Displayname { get; set; }

    public string? Resourcetype { get; set; }

    public string? Module { get; set; }

    public string? Path { get; set; }

    public bool? Isactive { get; set; }

    public string? Parentid { get; set; }

    public virtual ICollection<OsusrE9aCsicpSy035> InverseParent { get; set; } = new List<OsusrE9aCsicpSy035>();

    public virtual ICollection<OsusrE9aCsicpSy036> OsusrE9aCsicpSy036s { get; set; } = new List<OsusrE9aCsicpSy036>();

    public virtual ICollection<OsusrE9aCsicpSy037> OsusrE9aCsicpSy037s { get; set; } = new List<OsusrE9aCsicpSy037>();

    public virtual ICollection<OsusrE9aCsicpSy043> OsusrE9aCsicpSy043s { get; set; } = new List<OsusrE9aCsicpSy043>();

    public virtual OsusrE9aCsicpSy035? Parent { get; set; }
}
