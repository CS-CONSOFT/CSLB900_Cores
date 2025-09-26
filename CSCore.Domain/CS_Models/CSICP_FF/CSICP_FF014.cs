using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF014
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff014Filialid { get; set; }

    public int? Ff014Handle { get; set; }

    public string? Ff014Descricao { get; set; }

    public string? Ff014Comissaoid { get; set; }

    public int? Ff014Diasde { get; set; }

    public int? Ff014Diasate { get; set; }

    public decimal? Ff014Perccomissao { get; set; }

    public CSICP_BB001? NavBB001 { get; set; }
    public IEnumerable<CSICP_FF014>? NavFF014ComissaoFilho { get; set; }
}
