using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg015
{
    public int TenantId { get; set; }

    public string Cg015Id { get; set; } = null!;

    public string? Cg015FilialId { get; set; }

    public int? Cg015RateioId { get; set; }

    public string? Cg015TiposaldoId { get; set; }

    public string? Cg015Descricao { get; set; }

    public decimal? Cg015Valorbase { get; set; }

    public decimal? Cg015Totalrateiodeb { get; set; }

    public decimal? Cg015Totalrateiocre { get; set; }
}
