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

    //public virtual Osusr8dwCsicpCg994? Cg015Rateio { get; set; }

    //public virtual Osusr8dwCsicpCg008? Cg015Tiposaldo { get; set; }

    //public virtual ICollection<Osusr8dwCsicpCg016> Osusr8dwCsicpCg016s { get; set; } = new List<Osusr8dwCsicpCg016>();
}
