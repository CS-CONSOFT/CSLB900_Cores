using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

//Resource Attribute
public partial class ABAC_CSSPH_RESOURCEATRIB
{
    public int? TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Resourceid { get; set; }

    public string? Attributename { get; set; }

    public string? Attributevalue { get; set; }

    public string? Attributetype { get; set; }


}
