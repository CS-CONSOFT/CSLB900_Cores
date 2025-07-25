using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class CSICP_Bb021a
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb021aFilial { get; set; }

    public decimal? Bb021aCiOrigem { get; set; }

    public int? Bb021aCiOrigemSeq { get; set; }

    public int? Bb021aNoestacao { get; set; }

    public string? Bb021aTabela { get; set; }

    public decimal? Bb021aNoautorizacao { get; set; }

    public DateTime? Bb021aDataemissao { get; set; }
}
