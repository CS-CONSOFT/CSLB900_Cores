using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg022
{
    public int TenantId { get; set; }

    public string Cg022Id { get; set; } = null!;

    public string? Cg022FilialId { get; set; }

    public string? Cg022LoteId { get; set; }

    public string? Cg022LanctoId { get; set; }

    public int? Cg022Nrolancto { get; set; }

    public virtual Osusr8dwCsicpCg021? Cg022Lancto { get; set; }

    public virtual Osusr8dwCsicpCg020? Cg022Lote { get; set; }
}
