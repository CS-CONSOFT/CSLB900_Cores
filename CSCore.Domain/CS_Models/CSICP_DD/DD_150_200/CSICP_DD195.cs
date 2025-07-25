using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD195
{
    public int TenantId { get; set; }

    public long Dd195Id { get; set; }

    public long? Dd191Id { get; set; }

    public string? Dd195Usuariopropid { get; set; }

    public DateTime? Dd195Dinclusao { get; set; }

    public string? Dd195Motivo { get; set; }

    public decimal? Dd195Qtdanterior { get; set; }

    public decimal? Dd195Qtdnova { get; set; }

    public virtual CSICP_DD191? Dd191 { get; set; }
}
