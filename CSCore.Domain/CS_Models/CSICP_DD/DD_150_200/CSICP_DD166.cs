using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD166
{
    public int TenantId { get; set; }

    public long Dd166Id { get; set; }

    public string? Dd166Estabid { get; set; }

    public string? Dd166Ncupomdesconto { get; set; }

    public string? Dd166Contaid { get; set; }

    public int? Dd166Tcupomid { get; set; }

    public decimal? Dd166Pdesconto { get; set; }

    public decimal? Dd166Vdesconto { get; set; }

    public int? Dd166Statusid { get; set; }

    public DateTime? Dd166Diniciouso { get; set; }

    public DateTime? Dd166Dfinaluso { get; set; }

    public DateTime? Dd166Dregistro { get; set; }

    public DateTime? Dd166Dresgate { get; set; }

    public string? Dd166Usuariopropid { get; set; }

    public string? Dd166Sms { get; set; }

    public string? Dd166Email { get; set; }

    public virtual CSICP_DD166Stat? Dd166Status { get; set; }

    public virtual CSICP_DD165Tcp? Dd166Tcupom { get; set; }
}
