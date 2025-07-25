using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD046
{
    public int TenantId { get; set; }

    public string Dd046Id { get; set; } = null!;

    public string? Dd045Id { get; set; }

    public string? Dd040Id { get; set; }

    public int? Dd046Filial { get; set; }

    public decimal? Dd046Ci { get; set; }

    public string? Dd046NumProcesso { get; set; }

    public int? Dd046OrigemProcesso { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD045? Dd045 { get; set; }

    public virtual CSICP_DD046Pro? Dd046OrigemProcessoNavigation { get; set; }
}
