using CSCore.Domain.CS_Models.CSICP_GG;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.Staticas.GG;

public partial class CSICP_GG030Est
{
    public int TenantId { get; set; }

    public long Gg030aId { get; set; }

    public string? Gg030Id { get; set; }    

    public string? Bb001Id { get; set; }
    public CSICP_BB001? NavBB001 { get; set; }
}
