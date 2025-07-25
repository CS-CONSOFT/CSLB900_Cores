using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD135
{
    public int TenantId { get; set; }

    public string Dd135Id { get; set; } = null!;

    public string? Dd134Id { get; set; }

    public int? Dd135Prioridade { get; set; }

    public string? Dd135CcustoId { get; set; }

    public string? Dd135ResponsavelId { get; set; }

    public string? Dd135FormaPagtoId { get; set; }

    public string? Dd135ProdutoId { get; set; }

    public string? Dd135GrupoId { get; set; }

    public string? Dd135ClasseId { get; set; }

    public string? Dd135MarcaId { get; set; }

    public decimal? Dd135PercComissao { get; set; }

    public virtual CSICP_DD134? Dd134 { get; set; }
}
