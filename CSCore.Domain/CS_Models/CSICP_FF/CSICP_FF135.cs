using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF135
{
    public int TenantId { get; set; }

    public string Ff135CartadebitoId { get; set; } = null!;

    public string? Ff135Protocolnumber { get; set; }

    [ForeignKey("NavCSICP_BB001")]
    public string? Ff135FilialId { get; set; }
    public CSICP_BB001? NavCSICP_BB001 { get; set; }

    [ForeignKey("NavCSICP_BB012")]
    public string? Ff135ContafornecId { get; set; }
    public CSICP_BB012? NavCSICP_BB012 { get; set; }

    public DateTime? Ff135DataMovto { get; set; }

    public decimal? Ff135Vcarta { get; set; }

    public decimal? Ff135VsaldoCarta { get; set; }

    public string? Ff135UsuariopropId { get; set; }

    public string? Ff135Email { get; set; }

    public string? Ff135Sms { get; set; }

    [ForeignKey("NavFf135Status")]
    public int? Ff135Statusid { get; set; }
    public OsusrE9aCsicpFf135Status? NavFf135Status { get; set; }
}
