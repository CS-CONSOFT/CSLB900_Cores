using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD152
{
    public int TenantId { get; set; }

    public int Dd152Id { get; set; }

    public int? Dd151Detmontagemid { get; set; }

    public string? Dd152Montadorid { get; set; }

    public DateTime? Dd152Diniciomontagem { get; set; }

    public DateTime? Dd152Dfinalmontagem { get; set; }

    public int? Dd150Statusid { get; set; }

    public decimal? Dd152Vbasevenda { get; set; }

    public decimal? Dd152Vunitmontagem { get; set; }

    public decimal? Dd152Vcomissao { get; set; }

    public decimal? Dd152Pincentivo { get; set; }

    public virtual CSICP_DD150St? Dd150Status { get; set; }

    public virtual CSICP_DD151? Dd151Detmontagem { get; set; }

    public virtual CSICP_DD158? Dd152Montador { get; set; }
}
