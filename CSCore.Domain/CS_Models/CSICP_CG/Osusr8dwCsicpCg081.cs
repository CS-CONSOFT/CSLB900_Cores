using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.CG;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg081
{
    public int TenantId { get; set; }

    public long Cg081Id { get; set; }

    [ForeignKey("NavCG081ContRelConf")]
    public long? Cg081Contrelconfid { get; set; }

    [ForeignKey("NavCG081ASID")]
    public int? Cg081Asid { get; set; }

    public string? Cg081Txdescricao { get; set; }

    [ForeignKey("NavCG081ContRelRegistroSup")]
    public long? Cg081Contrelregistrosup { get; set; }

    [ForeignKey("NavNaturezaSaldo")]
    public int? Cg081Naturezasaldo { get; set; }

    public long? Cg081Nrlinha { get; set; }

    public int? Cg081Nrgrau { get; set; }

    public bool? Cg081Fllinharetaap { get; set; }

    public bool? Cg081Fllinhatracap { get; set; }

    public bool? Cg081Flnegrito { get; set; }

    public bool? Cg081Flespacobranco { get; set; }

    public string? Cg081Txnotaexplicativa { get; set; }

    public bool? Cg081Isnewpage { get; set; }

    public int? Cg081Treeorder { get; set; }

    public Osusr8dwCsicpCg080? NavCG081ContRelConf { get; set; }
    public Osusr8dwCsicpCg997? NavCG081ASID { get; set; }
    public Osusr8dwCsicpCg081? NavCG081ContRelRegistroSup { get; set; }
    public OsusrE9aCsicpGg993? NavCG993NaturezaSaldo { get; set; }
}
