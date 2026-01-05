using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD810
{
    public int TenantId { get; set; }

    public string Dd810Id { get; set; } = null!;

    public int? Dd810CfopSaida { get; set; }

    public int? Dd810CfopEntrada { get; set; }

    public string? Dd810Anotacao { get; set; }

    public string? Dd810Hashid { get; set; }

    public Osusr66cSpedInCfop NavDD810_CFOP_Saida { get; set; }

    public Osusr66cSpedInCfop NavDD810_CFOP_Entrada { get; set; }
}
