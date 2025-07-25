using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD806
{
    public int TenantId { get; set; }

    public string Dd806Id { get; set; } = null!;

    public string? Dd806EstabelecimentoId { get; set; }

    public DateTime? Dd806Anomesmovimento { get; set; }

    public string? Dd806ProdutoId { get; set; }

    public string? Dd806KardexId { get; set; }

    public decimal? Dd806Qconsumomedio { get; set; }

    public decimal? Dd806Qestqmin { get; set; }

    public decimal? Dd806Qestqmax { get; set; }

    public decimal? Dd806Qpontopedido { get; set; }

    public decimal? Dd806Qle { get; set; }
}
