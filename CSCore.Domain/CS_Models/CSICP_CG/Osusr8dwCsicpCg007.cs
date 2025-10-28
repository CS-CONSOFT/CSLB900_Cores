using CSCore.Domain.CS_Models.Staticas.CG;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg007
{
    public int TenantId { get; set; }

    public string Cg007Id { get; set; } = null!;

    public string? Cg007FilialId { get; set; }

    public string? Cg007Codigo { get; set; }

    public string? Cg007Descricao { get; set; }

    public string? Cg007Objetivo { get; set; }

    public bool? Cg007Isactive { get; set; }

    public DateTime? Cg007DataInicio { get; set; }

    public DateTime? Cg007DataFim { get; set; }

    public string? Cg007UserpropId { get; set; }

    public int? Cg007StatusId { get; set; }

    //public virtual Osusr8dwCsicpCg007Stat? Cg007Status { get; set; }

    //public virtual ICollection<Osusr8dwCsicpCg021> Osusr8dwCsicpCg021s { get; set; } = new List<Osusr8dwCsicpCg021>();
}
