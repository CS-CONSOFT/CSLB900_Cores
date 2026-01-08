using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

//Resource Action
public partial class ABAC_CSSPH_RESOURCEACTIONS
{

    public string Id { get; set; } = null!;

    public string? Resourceid { get; set; }

    public string? Actionname { get; set; }
    [Column("DISPLAYNAME")]
    public string? DisplayName { get; set; }

    [Column("DESCRIPTION")]
    public string? Description { get; set; }

}



