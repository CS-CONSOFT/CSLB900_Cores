using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD011
{
    public int TenantId { get; set; }

    public string Dd011Id { get; set; } = null!;

    public string? Dd010Id { get; set; }

    public string? Dd011FormapagtoId { get; set; }

    public string? Dd011TabelaPreco { get; set; }

    public int? Dd011ColunaPreco { get; set; }

    public decimal? Dd011ValorFaixaAte { get; set; }

    public string? Dd011Tabelaprecoid { get; set; }

    public virtual CSICP_DD010? Dd010 { get; set; }
}
