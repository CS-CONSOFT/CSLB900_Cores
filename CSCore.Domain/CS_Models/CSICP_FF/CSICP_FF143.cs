using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF143
{
    public int TenantId { get; set; }

    public long Ff143Id { get; set; }

    public long? Ff140RdId { get; set; }

    public byte[]? Ff143Objeto { get; set; }

    public string? Ff143Filetype { get; set; }

    public string? Ff143Texto { get; set; }

    public string? Filename { get; set; }

    public string? Ff143Path { get; set; }

    [JsonIgnore]
    public CSICP_FF140? NavFF140 { get; set; }
}
