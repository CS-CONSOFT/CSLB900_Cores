using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG000
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity )]
    public long Gg000Id { get; set; }

    public int? Gg000Ultcodigo { get; set; }

    public DateTime? Gg000Diltregistro { get; set; }

    public string? Gg000AltUsuarioid { get; set; }

    public DateTime? Gg000AltData { get; set; }

    public string? Gg000AwsBucket { get; set; }

    public string? Gg000Awsregion { get; set; }

    public string? Gg000Awsaccesskeyid { get; set; }

    public string? Gg000Awssecretaccesskey { get; set; }
}
