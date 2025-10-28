using CSCore.Domain.CS_Models.Staticas.CG;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg001
{
    public int TenantId { get; set; }

    public string Cg001Id { get; set; } = null!;

    public string? Cg001FilialId { get; set; }

    public int? Cg001Codigo { get; set; }

    public int? Cg001Exercicio { get; set; }

    public int? Cg001Periodo { get; set; }

    public DateTime? Cg001Dtinicial { get; set; }

    public DateTime? Cg001Dtfinal { get; set; }

    public int? Cg001Status { get; set; }

    //public virtual Osusr8dwCsicpCg002Stat? Cg001StatusNavigation { get; set; }
}
