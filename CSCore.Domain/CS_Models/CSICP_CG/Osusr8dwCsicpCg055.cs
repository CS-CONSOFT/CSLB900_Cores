using CSCore.Domain.CS_Models.Staticas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg055
{
    public int TenantId { get; set; }

    public long Cg055Id { get; set; }

    public string? Cg055Txcodigo { get; set; }

    public string? Cg055Txdescricao { get; set; }

    [ForeignKey("NavModuloID_CG055")]
    public int? Cg055Moduloid { get; set; }
    public OsusrNnxCsicpModulo? NavModuloID_CG055 { get; set; }
}
