using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD090
{
    public int TenantId { get; set; }

    public string Dd090Id { get; set; } = null!;

    public string? Dd070Id { get; set; }

    public string? Dd090Mensagem { get; set; }

    public int? Cc049SeveridadeId { get; set; }

    public string? Dd080Id { get; set; }

    public bool? Dd090Isactive { get; set; }

    public DateTime? Dd090Datahora { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }

    public virtual CSICP_DD080? Dd080 { get; set; }
}
