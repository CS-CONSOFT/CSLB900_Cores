using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class SpedCsicpServcorreio
{
    public string Id { get; set; } = null!;

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }
}
