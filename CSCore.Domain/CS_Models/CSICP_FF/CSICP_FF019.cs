using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF019
{
    public int TenantId { get; set; }

    public long Ff019Id { get; set; }

    public string? Ff000Id { get; set; }


    [ForeignKey("NavFormaPgto")]
    public string? Ff019FpagtoId { get; set; }

    [ForeignKey("NavCondicaoPgto")]
    public string? Ff019Condicaoid { get; set; }

    public CSICP_Bb008? NavCondicaoPgto { get; set; }
    public CSICP_Bb026? NavFormaPgto { get; set; }
}
