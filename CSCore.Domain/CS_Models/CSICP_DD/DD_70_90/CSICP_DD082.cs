using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD082
{
    public int TenantId { get; set; }

    public string Dd080Id { get; set; } = null!;

    public decimal? Dd082NumeroDi { get; set; }

    public DateTime? Dd082DataDi { get; set; }

    public string? Dd082Xlocdesemb { get; set; }

    public string? Dd082UfdesembId { get; set; }

    public string? Dd082Ufdesemb { get; set; }

    public DateTime? Dd082Datadesemb { get; set; }

    public string? Dd082Cexportador { get; set; }

    public string? Dd082Regimedrawback { get; set; }

    public int? Dd082ModalId { get; set; }

    public decimal? Dd082Vafmm { get; set; }

    public int? Dd082TpintermId { get; set; }

    public string? Dd082Cnpj { get; set; }

    public string? Dd082Ufterceiro { get; set; }

    public virtual CSICP_DD080 Dd080 { get; set; } = null!;

    public virtual CSICP_DD062Imp? Dd082Tpinterm { get; set; }
}
