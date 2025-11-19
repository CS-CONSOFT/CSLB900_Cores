using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class OsusrE9aCsicpNn004
{
    public int TenantId { get; set; }

    public string Nn004ClasseId { get; set; } = null!;

    public string? Nn004FilialId { get; set; }

    public int? Nn004Filial { get; set; }

    public int? Nn004CodClasse { get; set; }

    public string? Nn004Descricao { get; set; }

    public bool? Nn004Isactive { get; set; }
}
