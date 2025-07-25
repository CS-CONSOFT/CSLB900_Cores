using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg065
{
    public int TenantId { get; set; }

    public long Gg065Id { get; set; }

    public string? Gg065IdUnico { get; set; }

    public string? Gg065Descricao { get; set; }

    public int? Gg065Ordem { get; set; }

    public ICollection<OsusrE9aCsicpGg066> OsusrE9aCsicpGg066s { get; set; } = new List<OsusrE9aCsicpGg066>();

    public ICollection<OsusrE9aCsicpGg068> OsusrE9aCsicpGg068s { get; set; } = new List<OsusrE9aCsicpGg068>();
}
