using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class Csicp_Sy012
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy012Userid { get; set; }

    public string? Sy904ProgramaId { get; set; }

    public Csicp_Sy001? Sy012User { get; set; }
}
