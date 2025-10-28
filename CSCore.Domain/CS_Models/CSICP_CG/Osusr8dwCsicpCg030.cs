using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg030
{
    public int TenantId { get; set; }

    public string Cg030Id { get; set; } = null!;

    public DateTime? Cg030Datacreate { get; set; }

    public string? Cg030PropUserId { get; set; }

    public string? Cg030Mensagem { get; set; }
}
