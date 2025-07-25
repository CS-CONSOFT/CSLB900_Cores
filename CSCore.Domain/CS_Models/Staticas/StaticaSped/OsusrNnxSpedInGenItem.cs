using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class OsusrNnxSpedInGenItem
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }
}
