using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class OsusrNnxSpedInEmitente
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public string? Codigo { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }
}
