using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD010
{
    public int TenantId { get; set; }

    public string Dd010Id { get; set; } = null!;

    public string? Dd010Empresaid { get; set; }

    public string? Dd010Descricao { get; set; }

    public string? Dd010Contaid { get; set; }

    public string? Dd010RotaId { get; set; }

    public DateTime? Dd010DataValidade { get; set; }

    public string? Dd010Protocolnumber { get; set; }
}
