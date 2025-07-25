using System;
using System.Collections.Generic;
using CSCore.Domain.CS_Models.Staticas.FF;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF005
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff005Filialid { get; set; }

    public int? Ff005Tipo { get; set; }

    public string? Ff003Especieid { get; set; }

    public decimal? Ff005Sequencia { get; set; }

    public string? Ff005Contafornid { get; set; }

    public int? Ff005Diavencimento { get; set; }

    public string? Ff005Pfx { get; set; }

    public int? Ff005ImpostoId { get; set; }

    public virtual CSICP_FF003? Ff003Especie { get; set; }

    public CSICP_FF003? NavFF003 { get; set; }

    public OsusrE9aCsicpFf003Tpesp? NavFF003TpEsp { get; set; }

    public CSICP_AA037Imp? NavAA037Imp { get; set; }
}
