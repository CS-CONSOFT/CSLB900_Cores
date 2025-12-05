using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg060
{
    public int TenantId { get; set; }

    public long Cg060Id { get; set; }

    [ForeignKey("NavCG050Evento_CG060")]
    public long? Cg060Eventoid { get; set; }

    public DateTime? Cg060Dtini { get; set; }

    public DateTime? Cg060Dtfim { get; set; }

    public int? Cg060Nrnumero { get; set; }

    public bool? Cg060Flagrupadeb { get; set; }

    public bool? Cg060Flagrupacred { get; set; }

    [ForeignKey("NavCG050EventoTpDeb_CG060")]
    public long? Cg060Eventotpdebid { get; set; }

    [ForeignKey("NavCG050EventoTpCred_CG060")]
    public long? Cg060Eventotpcredid { get; set; }

    public string? Cg060Txdescricao { get; set; }

    [ForeignKey("NavBB001Estab_CG060")]
    public string? Cg060Estabid { get; set; }

    public int? Cg060Idprevia { get; set; }

    public int? Cg060Qparprenchidos { get; set; }

    public Osusr8dwCsicpCg050? NavCG050Evento_CG060 { get; set; }
    public Osusr8dwCsicpCg050? NavCG050EventoTpDeb_CG060 { get; set; }
    public Osusr8dwCsicpCg050? NavCG050EventoTpCred_CG060 { get; set; }
    public CSICP_BB001? NavBB001Estab_CG060 { get; set; }
}
