using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class Csicp_Sy993
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy993EmpresaId { get; set; }

    public string? Sy993Modulo { get; set; }

    public string? Sy993Descricao { get; set; }

    public DateTime? Sy993Data { get; set; }
}
