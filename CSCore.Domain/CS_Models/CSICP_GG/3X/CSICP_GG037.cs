using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG037
{
    public int TenantId { get; set; }

    public string Gg037Id { get; set; } = null!;

    public string? Gg037FilialId { get; set; }

    public string? Gg037InventarioId { get; set; }

    public string? Gg037SaldoId { get; set; }

    public decimal? Gg037QtdNconfirmidade { get; set; }

    public bool? Gg037GeradoListaInv { get; set; }

    //public OsusrE9aCsicpGg032? Gg037Inventario { get; set; }
}
