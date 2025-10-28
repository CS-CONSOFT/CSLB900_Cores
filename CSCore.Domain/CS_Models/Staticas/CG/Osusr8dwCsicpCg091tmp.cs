using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.Staticas.CG;

public partial class Osusr8dwCsicpCg091tmp
{
    public int TenantId { get; set; }

    public long Cg091Id { get; set; }

    public long? Cg091Conttempdemid { get; set; }

    public long? Cg091Conttempdemcab { get; set; }

    public decimal? Cg091Vlvalor { get; set; }

    public virtual Osusr8dwCsicpCg090tmp? Cg091Conttempdem { get; set; }

    public virtual Osusr8dwCsicpCg092tmp? Cg091ConttempdemcabNavigation { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg093tmp> Osusr8dwCsicpCg093tmps { get; set; } = new List<Osusr8dwCsicpCg093tmp>();
}
