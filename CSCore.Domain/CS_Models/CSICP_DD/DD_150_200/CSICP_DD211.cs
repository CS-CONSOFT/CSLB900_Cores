using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD211
{
    public int TenantId { get; set; }

    public long Dd211Id { get; set; }

    public int? Dd210Seguroid { get; set; }

    public string? Dd211CodgProduto { get; set; }

    public string? Dd211Descproduto { get; set; }
}
