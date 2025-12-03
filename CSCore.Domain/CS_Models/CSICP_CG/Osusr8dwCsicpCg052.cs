using CSCore.Domain.CS_Models.Staticas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg052
{
    public int TenantId { get; set; }

    public long Cg052Id { get; set; }

    public string? Cg052Txcodigo { get; set; }

    public string? Cg052Txdescricao { get; set; }

    public string? Cg052Txcomando { get; set; }

    public string? Cg052Txtabelas { get; set; }

    [ForeignKey("NavModuloID_CG052")]
    public int? Cg052Moduloid { get; set; }

    public OsusrNnxCsicpModulo? NavModuloID_CG052 { get; set; }
}
