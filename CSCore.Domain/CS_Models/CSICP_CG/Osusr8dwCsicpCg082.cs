using CSCore.Domain.CS_Models.CSICP_GG;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg082
{
    public int TenantId { get; set; }

    public long Cg082Id { get; set; }

    [ForeignKey("NavCG081ContRelRegID_CG082")]
    public long? Cg082Contrelregid { get; set; }

    [ForeignKey("NavCG006ContConta_CG082")]
    public string? Cg082Contcontaid { get; set; }

    public DateTime? Cg082Dateinicial { get; set; }

    public DateTime? Cg082Datefinal { get; set; }

    public Osusr8dwCsicpCg081? NavCG081ContRelRegID_CG082 { get; set; }
    public CSICP_CG006? NavCG006ContConta_CG082 { get; set; }
}
