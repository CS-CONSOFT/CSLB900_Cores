using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD160
{
    public int TenantId { get; set; }

    public long Dd160Id { get; set; }

    public string? Dd160Descricao { get; set; }

    public decimal? Dd160Pincentivo { get; set; }

    public decimal? Dd160Pinccompartilhado { get; set; }
}
