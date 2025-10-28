using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg038
{
    public int TenantId { get; set; }

    public long Cg038Id { get; set; }

    public long? Cg037Id { get; set; }

    public string? Cg032ContadreId { get; set; }

    public decimal? Cg038Sldanterior { get; set; }

    public decimal? Cg038Vmes1 { get; set; }

    public decimal? Cg038Vmes2 { get; set; }

    public decimal? Cg038Vmes3 { get; set; }

    public decimal? Cg038Vmes4 { get; set; }

    public decimal? Cg038Vmes5 { get; set; }

    public decimal? Cg038Vmes6 { get; set; }

    public decimal? Cg038Vmes7 { get; set; }

    public decimal? Cg038Vmes8 { get; set; }

    public decimal? Cg038Vmes9 { get; set; }

    public decimal? Cg038Vmes10 { get; set; }

    public decimal? Cg038Vmes11 { get; set; }

    public decimal? Cg038Vmes12 { get; set; }

    public decimal? Cg038Sldatual { get; set; }

    public virtual Osusr8dwCsicpCg032? Cg032Contadre { get; set; }

    public virtual Osusr8dwCsicpCg037? Cg037 { get; set; }
}
