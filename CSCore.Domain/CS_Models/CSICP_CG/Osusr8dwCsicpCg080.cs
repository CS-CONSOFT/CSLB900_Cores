using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg080
{
    public int TenantId { get; set; }

    public long Cg080Id { get; set; }

    public string? Cg080Nome { get; set; }

    public DateTime? Cg080Dtvigenciaini { get; set; }

    public DateTime? Cg080Dtvigenciafim { get; set; }

    public bool? Cg080Isactive { get; set; }

    public bool? Cg080Isprojfromprov { get; set; }

    //public virtual ICollection<Osusr8dwCsicpCg081> Osusr8dwCsicpCg081s { get; set; } = new List<Osusr8dwCsicpCg081>();
}
