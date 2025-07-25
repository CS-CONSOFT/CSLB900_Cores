using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.Staticas.FF;

public partial class CSICP_FF102Cob
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public int? Codgcs { get; set; }
}
