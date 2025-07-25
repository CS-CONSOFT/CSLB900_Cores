using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD001
{
    public int TenantId { get; set; }

    public string Dd001Id { get; set; } = null!;

    public string? Dd001Empresaid { get; set; }

    public int? Dd001Filial { get; set; }

    public string? Dd001Descricao { get; set; }

    public bool? Dd001Isactive { get; set; }

    public DateTime? Dd001Datainicio { get; set; }

    public DateTime? Dd001Datafim { get; set; }

    public string? Dd001Protocolnumber { get; set; }
}
