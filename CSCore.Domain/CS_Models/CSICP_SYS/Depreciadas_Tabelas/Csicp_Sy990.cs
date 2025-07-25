using CSCore.Domain.CS_Models.CSICP_SYS;
using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class Csicp_Sy990
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Auditarsistema { get; set; }

    public string? Usuarioid { get; set; }

    public int? Userid { get; set; }

    public string? Grupoid { get; set; }

    public int? Auditar { get; set; }

    public Csicp_Sy002? Grupo { get; set; }

    public Csicp_Sy001? Usuario { get; set; }
}
