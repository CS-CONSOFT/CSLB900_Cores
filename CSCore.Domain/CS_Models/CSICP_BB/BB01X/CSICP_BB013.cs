using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class CSICP_Bb013
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb013Codigo { get; set; }

    public string? Bb013Bairro { get; set; }

    public string? Bb013Codgcidade { get; set; }

    //public ICollection<CSICP_Bb006> OsusrE9aCsicpBb006s { get; set; } = new List<CSICP_Bb006>();
}
