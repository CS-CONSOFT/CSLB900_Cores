using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD005
{
    public int TenantId { get; set; }

    public string Dd005Id { get; set; } = null!;

    public string? Dd004Id { get; set; }

    public string? Dd005ProdutoId { get; set; }

    public string? Dd005MarcaprodutoId { get; set; }

    public string? Dd005ClasseprodutoId { get; set; }

    public string? Dd005GrupoprodutoId { get; set; }

    public decimal? Dd005Percentual { get; set; }

    public decimal? Dd005ValorFaixaAte { get; set; }

    public virtual CSICP_DD004? Dd004 { get; set; }
}
