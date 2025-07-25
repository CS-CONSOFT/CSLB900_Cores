using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF103a
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int Ff103aSeqid { get; set; }

    public string? Ff103Id { get; set; }

    public string? Ff103Filialid { get; set; }

    public int? Ff103aFilial { get; set; }

    public string? Ff103aPfx { get; set; }

    public decimal? Ff103aNroTitulo { get; set; }

    public string? Ff103aSfx { get; set; }

    public int? Ff103aSeqBaixa { get; set; }

    public string? Ff103aTipo { get; set; }

    public string? Ff103aStatus { get; set; }

    public virtual CSICP_FF103? Ff103 { get; set; }
}
