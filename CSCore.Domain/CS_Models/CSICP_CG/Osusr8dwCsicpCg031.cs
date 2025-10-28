using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg031
{
    public int TenantId { get; set; }

    public string Cg031Id { get; set; } = null!;

    public string? Cg031Codigo { get; set; }

    public string? Cg031Descricao { get; set; }

    public string? Cg031TipoSaldoId { get; set; }

    public string? Cg031UserpropId { get; set; }

    public DateTime? Cg031Dinclusao { get; set; }

    //public virtual Osusr8dwCsicpCg008? Cg031TipoSaldo { get; set; }

    //public virtual ICollection<Osusr8dwCsicpCg032> Osusr8dwCsicpCg032s { get; set; } = new List<Osusr8dwCsicpCg032>();

    //public virtual ICollection<Osusr8dwCsicpCg037> Osusr8dwCsicpCg037s { get; set; } = new List<Osusr8dwCsicpCg037>();
}
