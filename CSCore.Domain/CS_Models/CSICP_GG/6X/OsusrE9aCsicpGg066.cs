using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg066
{
    public int TenantId { get; set; }

    public long Gg066Id { get; set; }

    public long? Gg065Id { get; set; }

    public string? Gg066Descricao { get; set; }

    public string? Gg066Idunico { get; set; }

    public OsusrE9aCsicpGg065? Gg065 { get; set; }

    public ICollection<OsusrE9aCsicpGg067> OsusrE9aCsicpGg067s { get; set; } = new List<OsusrE9aCsicpGg067>();
}
