using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD274Uploadxml
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sessionid { get; set; }

    public string? Filename { get; set; }

    public string? Filetype { get; set; }

    public decimal? Filesize { get; set; }

    public byte[]? Content { get; set; }

    public DateTime? Created { get; set; }

    public string? Chave { get; set; }

    public int? Numnfe { get; set; }

    public bool? Isdanfe { get; set; }

    public bool? Isimportada { get; set; }

    public string? Xml { get; set; }
}
