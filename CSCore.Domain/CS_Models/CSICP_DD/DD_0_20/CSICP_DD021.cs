using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD021
{
    public int TenantId { get; set; }

    public string Dd021Id { get; set; } = null!;

    public string? Dd020Id { get; set; }

    public string? Dd021Usuarioid { get; set; }

    public string? Dd021ResponsavelId { get; set; }

    public decimal? Dd021Vmetavenda { get; set; }

    public decimal? Dd021Vdevolucoes { get; set; }

    public virtual CSICP_DD020? Dd020 { get; set; }
}
