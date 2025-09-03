using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF003
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff003Filialid { get; set; }

    public int? Ff003Tipoespecie { get; set; }

    public int? Ff003Codigo { get; set; }

    public string? Ff003Descricao { get; set; }

    public string? Ff003Descresumida { get; set; }

    public string? Ff003Pfx { get; set; }

    public int? Ff003Provisao { get; set; }

    public string? Ff003Ccustoid { get; set; }

    public string? Ff003Lctoenttitulosid { get; set; }

    public string? Ff003Lctobxnormalid { get; set; }

    public string? Ff003Lctobxdevolucaoid { get; set; }

    public decimal? Ff003Seqnrotitulo { get; set; }
    public CSICP_BB001? NavBB001 { get; set; }
    public OsusrE9aCsicpFf003Tpesp? NavFF003TpEsp { get; set; }
    public CSICP_Statica? NavStatica { get; set; }

    public CSICP_Bb005? NavBB005 { get; set; }
}
