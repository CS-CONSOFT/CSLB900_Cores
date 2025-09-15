using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF116
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Ff116Tipomovto { get; set; }

    public string? Ff116Filialid { get; set; }

    public DateTime? Ff116Datamovto { get; set; }

    public string? Ff116Usuariopropid { get; set; }

    public string? Ff102Tituloid { get; set; }

    public DateTime? Ff116Datavencto { get; set; }

    public DateTime? Ff116Novovencto { get; set; }

    public string? Ff116Protocolnumber { get; set; }

    public decimal? Ff116Vnovovlr { get; set; }

    public decimal? Ff116Vvaloranterior { get; set; }

    public string? Ff116Msg { get; set; }


    // Navegações movidas do RepoDtoCSICP_FF116
    public CSICP_BB001? NavBB001 { get; set; }
    public OsusrE9aCsicpFf116Tmov? NavFF116TMov { get; set; }
    public Csicp_Sy001? NavSY001 { get; set; }
    public CSICP_FF102? NavFF102 { get; set; }
}
