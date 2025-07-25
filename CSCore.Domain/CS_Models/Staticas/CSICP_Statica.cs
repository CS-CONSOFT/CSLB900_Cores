using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class CSICP_Statica
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Tiporegistro { get; set; }

    public int? Order { get; set; }
}
