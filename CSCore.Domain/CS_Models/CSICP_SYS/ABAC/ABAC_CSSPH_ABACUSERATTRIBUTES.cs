using System;
using System.Collections.Generic;

namespace CSCore.Domain.DELETAR;

public partial class ABAC_CSSPH_ABACUSERATTRIBUTES
{
    public string Id { get; set; } = null!;

    public string? Attributename { get; set; }

    public string? Label { get; set; }

    public string? Datatype { get; set; }

    public string? Description { get; set; }

    public string? Enumvalues { get; set; }

    public bool? Iscore { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Createdat { get; set; }
}
