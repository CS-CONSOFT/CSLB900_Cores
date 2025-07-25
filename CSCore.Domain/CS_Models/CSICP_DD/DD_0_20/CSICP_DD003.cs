using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD003
{
    public int TenantId { get; set; }

    public string Dd003Id { get; set; } = null!;

    public string? Dd002Id { get; set; }

    public string? Dd003ProdutoId { get; set; }

    public string? Dd003MarcaprodutoId { get; set; }

    public string? Dd003ClasseprodutoId { get; set; }

    public string? Dd003GrupoprodutoId { get; set; }

    public decimal? Dd003Percentual { get; set; }

    public decimal? Dd003ValorFaixaAte { get; set; }

    public virtual CSICP_DD002? Dd002 { get; set; }
}
