using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg037
{
    public int TenantId { get; set; }

    public long Cg037Id { get; set; }

    public string? Cg031Id { get; set; }

    public string? Cg037Descricao { get; set; }

    public string? Cg037UserpropId { get; set; }

    public DateTime? Cg037Dregistro { get; set; }

    public int? Cg037Ano { get; set; }

    public int? Cg037Mesinicial { get; set; }

    public int? Cg037Mesfinal { get; set; }

    public virtual Osusr8dwCsicpCg031? Cg031 { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg038> Osusr8dwCsicpCg038s { get; set; } = new List<Osusr8dwCsicpCg038>();
}
