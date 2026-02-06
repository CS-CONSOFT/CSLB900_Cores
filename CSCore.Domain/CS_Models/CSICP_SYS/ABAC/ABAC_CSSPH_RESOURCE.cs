using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

//Resource
public partial class ABAC_CSSPH_RESOURCE
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; } = string.Empty!;

    public string? Displayname { get; set; }

    public string? Resourcetype { get; set; }

    public string? Module { get; set; }

    public string? Path { get; set; }

    public bool? Isactive { get; set; }

    public string? Parentid { get; set; }

    public ICollection<ABAC_CSSPH_RESOURCEACTIONS> NavResourceActions { get; set; } = [];
    public ICollection<ABAC_CSSPH_RESOURCEATRIB> NavResourceAttributes { get; set; } = [];
}
