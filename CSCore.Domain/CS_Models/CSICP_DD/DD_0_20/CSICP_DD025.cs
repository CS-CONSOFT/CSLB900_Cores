using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD025
{
    public int TenantId { get; set; }

    public string Dd025Id { get; set; } = null!;

    public string? Dd025Ano { get; set; }

    public string? Dd025Mes { get; set; }

    public string? Dd025Usuarioid { get; set; }

    public decimal? Dd025Vmetavenda { get; set; }

    public decimal? Dd025Vdevolucoes { get; set; }

    public int? Dd025Qvendedor { get; set; }

    public int? Dd025Statusid { get; set; }

    public int? Dd025Diasuteis { get; set; }

    public virtual CSICP_DD025Stat? Dd025Status { get; set; }
}
