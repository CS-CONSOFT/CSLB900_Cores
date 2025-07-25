using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD009
{
    public int TenantId { get; set; }

    public string Dd009Id { get; set; } = null!;

    public string? Dd009Empresaid { get; set; }

    public string? Dd009CategoriaId { get; set; }

    public string? Dd009FormapagtoId { get; set; }

    public bool? Dd009Isactive { get; set; }
}
