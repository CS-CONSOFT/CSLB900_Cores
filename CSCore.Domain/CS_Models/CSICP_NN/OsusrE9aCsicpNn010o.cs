using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class OsusrE9aCsicpNn010o
{
    public int TenantId { get; set; }

    public string Nn010oId { get; set; } = null!;

    public string? Nn010Id { get; set; }

    public string? Nn010oDescricao { get; set; }

    public byte[]? Nn010oContent { get; set; }

    public string? Nn010oFiletype { get; set; }

    public string? Nn010oFilename { get; set; }

    public bool? Nn010oIsActive { get; set; }

    public int? Nn010oTipoarq { get; set; }

    public string? Nn010oPath { get; set; }

}
