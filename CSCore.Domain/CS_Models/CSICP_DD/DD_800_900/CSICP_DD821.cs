using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD821
{
    public int TenantId { get; set; }

    public string Dd821Id { get; set; } = null!;

    public string? Dd821FilialId { get; set; }

    public string? Dd040Id { get; set; }

    public string? Dd821ProdutoaId { get; set; }

    public decimal? Dd821QtdProdutoa { get; set; }

    public decimal? Dd821Vprodutoa { get; set; }

    public string? Dd821ProdutobId { get; set; }

    public decimal? Dd821QtdProdutob { get; set; }

    public decimal? Dd821Vprodutob { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }
}
