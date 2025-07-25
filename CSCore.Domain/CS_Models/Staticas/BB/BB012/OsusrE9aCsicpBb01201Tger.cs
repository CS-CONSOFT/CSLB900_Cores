using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class CSICP_Bb01201Tger
{
    public int Id { get; set; }

    public string? Label { get; set; } = string.Empty;

    public int? Order { get; set; } = -1;

    public bool? IsActive { get; set; } = true;
}
