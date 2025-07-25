using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD165
{
    public int TenantId { get; set; }

    public long Dd165Id { get; set; }

    public string? Dd165Estabid { get; set; }

    public bool? Dd165Isperiodomensal { get; set; }

    public bool? Dd165Isperiodoquinz { get; set; }

    public bool? Dd165Isperiodocontrolado { get; set; }

    public int? Dd165Qdiasmenos { get; set; }

    public int? Dd165Qdiasmais { get; set; }

    public decimal? Dd165Pcupomdesc { get; set; }

    public decimal? Dd165Vcupomdesc { get; set; }

    public int? Dd165Tcupomid { get; set; }

    public virtual CSICP_DD165Tcp? Dd165Tcupom { get; set; }
}
