using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS;

public partial class Csicp_Sy025
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy025Usuarioid { get; set; }

    public string? Sy025Tipotoken { get; set; }

    public string? Sy025Refreshtoken { get; set; }

    public DateTime? Sy025Refreshexpiredtime { get; set; }

    public DateTime? Sy025Dtcreate { get; set; }
}
