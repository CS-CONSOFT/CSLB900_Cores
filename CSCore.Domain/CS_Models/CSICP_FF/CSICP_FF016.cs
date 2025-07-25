using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF016
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff016DescricaoCarta { get; set; }

    public byte[]? Ff016Texto { get; set; }

    public int? Ff016EmailsdestId { get; set; }

    public string? Ff016Textocarta { get; set; }
}
