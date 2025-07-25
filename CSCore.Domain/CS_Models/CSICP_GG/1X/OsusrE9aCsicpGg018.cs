using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg018
{
    public int TenantId { get; set; }

    public long Gg018Id { get; set; }

    public long? Gg017Categoriaid { get; set; }

    public string? Gg008Id { get; set; }

    public CSICP_GG008? Gg008 { get; set; }

    public CSICP_GG017? Gg017Categoria { get; set; }
}
