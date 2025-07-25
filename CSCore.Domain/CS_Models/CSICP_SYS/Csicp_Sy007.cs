using CSCore.Domain.CS_Models.CSICP_SYS;
using System;
using System.Collections.Generic;


namespace CSCore.Domain;

public partial class Csicp_Sy007
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy007Grupoid { get; set; }

    public int? Sy007RegraestaticaId { get; set; }

    public Csicp_Sy002? Sy007Grupo { get; set; }

    public Csicp_Sy003Regra? Sy007Regraestatica { get; set; }
}
