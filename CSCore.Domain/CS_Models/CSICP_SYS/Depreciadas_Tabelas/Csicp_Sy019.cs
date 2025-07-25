using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.Depreciadas_Tabelas;

public partial class Csicp_Sy019
{
    public int TenantId { get; set; }

    public long Sy019Id { get; set; }

    public string? Sy019Userid { get; set; }

    public string? Sy904ProgramaId { get; set; }

    public bool? Sy019Isactive { get; set; }

    public Csicp_Sy001? Sy019User { get; set; }
}
