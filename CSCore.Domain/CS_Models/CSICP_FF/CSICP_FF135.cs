using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF135
{
    public int TenantId { get; set; }

    public string Ff135CartadebitoId { get; set; } = null!;

    public string? Ff135Protocolnumber { get; set; }

    public string? Ff135FilialId { get; set; }

    public string? Ff135ContafornecId { get; set; }

    public DateTime? Ff135DataMovto { get; set; }

    public decimal? Ff135Vcarta { get; set; }

    public decimal? Ff135VsaldoCarta { get; set; }

    public string? Ff135UsuariopropId { get; set; }

    public string? Ff135Email { get; set; }

    public string? Ff135Sms { get; set; }

    public int? Ff135Statusid { get; set; }
}
