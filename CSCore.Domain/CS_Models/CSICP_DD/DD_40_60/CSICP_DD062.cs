using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD062
{
    public int TenantId { get; set; }

    public string Dd060Id { get; set; } = null!;

    public decimal? Dd062NumeroDi { get; set; }

    public DateTime? Dd062DataDi { get; set; }

    public string? Dd062Xlocdesemb { get; set; }

    public string? Dd062UfdesembId { get; set; }

    public string? Dd062Ufdesemb { get; set; }

    public DateTime? Dd062Datadesemb { get; set; }

    public string? Dd062Cexportador { get; set; }

    public string? Dd062Regimedrawback { get; set; }

    public int? Dd062ModalId { get; set; }

    public decimal? Dd062Vafmm { get; set; }

    public int? Dd062TpintermId { get; set; }

    public string? Dd062Cnpj { get; set; }

    public string? Dd062Ufterceiro { get; set; }

    public virtual CSICP_DD060 Dd060 { get; set; } = null!;

    public virtual CSICP_DD062Imp? Dd062Tpinterm { get; set; }
}
