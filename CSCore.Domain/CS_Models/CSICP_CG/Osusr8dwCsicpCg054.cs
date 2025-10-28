using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg054
{
    public int TenantId { get; set; }

    public long Cg054Id { get; set; }

    public long? Cg054Eventotpid { get; set; }

    public long? Cg054Valortpid { get; set; }

    public virtual Osusr8dwCsicpCg050? Cg054Eventotp { get; set; }

    public virtual Osusr8dwCsicpCg055? Cg054Valortp { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062Eventovalortpcreds { get; set; } = new List<Osusr8dwCsicpCg062>();

    public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062Eventovalortpdebs { get; set; } = new List<Osusr8dwCsicpCg062>();

    public virtual ICollection<Osusr8dwCsicpCg062> Osusr8dwCsicpCg062Cg062Eventovalortps { get; set; } = new List<Osusr8dwCsicpCg062>();

    public virtual ICollection<Osusr8dwCsicpCg072> Osusr8dwCsicpCg072s { get; set; } = new List<Osusr8dwCsicpCg072>();
}
