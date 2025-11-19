using CSCore.Domain.EstaticasLabel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class CSICP_CG000
{
    public int TenantId { get; set; }

    public string Cg000Id { get; set; } = null!;

    [ForeignKey("NavBB001Estab_CG000")]
    public string? Cg000Filialid { get; set; }

    public int? Cg000Graus { get; set; }

    public int? Cg000Dgrau1 { get; set; }

    public int? Cg000Dgrau2 { get; set; }

    public int? Cg000Dgrau3 { get; set; }

    public int? Cg000Dgrau4 { get; set; }

    public int? Cg000Dgrau5 { get; set; }

    public string? Cg000Mascaracta { get; set; }

    public int? Cg000Grausctager { get; set; }

    public int? Cg000Dgrau1Ctager { get; set; }

    public int? Cg000Dgrau2Ctager { get; set; }

    public int? Cg000Dgrau3Ctager { get; set; }

    public int? Cg000Dgrau4Ctager { get; set; }

    public int? Cg000Dgrau5Ctager { get; set; }

    public string? Cg000Mascaractager { get; set; }

    public int? Cg000Ultcodgredz { get; set; }

    [ForeignKey("NavStatica_CG000")]
    public int? Cg000Usacalendario { get; set; }

    public CSICP_BB001? NavBB001Estab_CG000 { get; set; }

    public CSICP_Statica? NavStatica_CG000 { get; set; }
}
