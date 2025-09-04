using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Domain.CS_Models.CSICP_AA;

public partial class CSICP_AA043
{

    [Key]
    public string Id { get; set; } = null!;

    public string? Aa043Artigo { get; set; }

    public string? Aa043LcRedacao { get; set; }

    public string? Aa043Ec { get; set; }
}
