using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD184
{
    public int TenantId { get; set; }

    public long Dd184Id { get; set; }

    public long? Dd181Id { get; set; }

    public string? Dd184ProdutoId { get; set; }

    public decimal? Dd184Qconferida { get; set; }

    public decimal? Dd184Qrealdanfe { get; set; }

    public int? Dd184Statusid { get; set; }

    public int? Dd184Modentregaid { get; set; }

    public bool? Dd184Isinseridopdv { get; set; }

    public virtual CSICP_DD181? Dd181 { get; set; }

    public virtual CSICP_DD110Mod? Dd184Modentrega { get; set; }
}
