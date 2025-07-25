using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg993
{
    public int TenantId { get; set; }

    public string Gg993Id { get; set; } = null!;

    public string? Gg993Empresaid { get; set; }

    public string? Gg993Saldoid { get; set; }

    public decimal? Gg993EstoqMin { get; set; }

    public decimal? Gg993EstqMax { get; set; }

    public decimal? Gg993QtdeReposicao { get; set; }

    public DateTime? Gg993Createon { get; set; }

    public string? Gg041RiId { get; set; }

    public string? Gg028Extratoid { get; set; }

    public bool? Gg993Isprocessado { get; set; }

    public CSICP_GG520? Gg993Saldo { get; set; }
}
