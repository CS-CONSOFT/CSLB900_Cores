using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD008
{
    public int TenantId { get; set; }

    public string Dd008Id { get; set; } = null!;

    public string? Dd008Empresaid { get; set; }

    public string? Dd008ResponsavelId { get; set; }

    public string? Dd008CargoId { get; set; }

    public string? Dd008FormapagtoId { get; set; }

    public string? Dd008CondpagtoId { get; set; }

    public decimal? Dd008Valorate { get; set; }

    public decimal? Dd008Percdesconto { get; set; }

    public bool? Dd008Isactive { get; set; }
}
