using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD163
{
    public int TenantId { get; set; }

    public long Dd163Id { get; set; }

    public string? Dd162Id { get; set; }

    public string? Gg008Id { get; set; }

    public decimal? Dd162Qtd { get; set; }

    public string? Dd163Anotacao { get; set; }

    public string? Dd163Usuariopropid { get; set; }

    public DateTime? Dd163Dcriacao { get; set; }

    public virtual CSICP_DD162? Dd162 { get; set; }
}
