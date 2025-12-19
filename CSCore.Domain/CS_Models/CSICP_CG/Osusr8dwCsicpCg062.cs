using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg062
{
    public int TenantId { get; set; }

    public long Cg062Id { get; set; }

    [ForeignKey("NavCG060RegramentoID_CG062")]
    public long? Cg062Regramentoid { get; set; }
    
    [ForeignKey("NavCG054EventoValorTpID_CG062")]
    public long? Cg062Eventovalortpid { get; set; }

    [ForeignKey("NavCG006ContaDeb_CG062")]
    public string? Cg062Contadebid { get; set; }

    [ForeignKey("NavCG005HistDeb_CG062")]
    public string? Cg062Histdebid { get; set; }
    
    [ForeignKey("NavCG006ContaCred_CG062")]
    public string? Cg062Contacredid { get; set; }

    [ForeignKey("NavCG005HistCred_CG062")]
    public string? Cg062Histcredid { get; set; }

    [ForeignKey("NavCG054EventoValorTpDebID_CG062")]
    public long? Cg062Eventovalortpdebid { get; set; }

    [ForeignKey("NavCG054EventoValorTpCredID_CG062")]
    public long? Cg062Eventovalortpcredid { get; set; }

    public bool? Cg062Isignorevalor { get; set; }

    public string? Cg062CtagerencialDebn2Id { get; set; }

    public string? Cg062CtagerencialDebn3Id { get; set; }

    public string? Cg062CtagerencialDebn4Id { get; set; }

    public string? Cg062CtagerencialCren2Id { get; set; }

    public string? Cg062CtagerencialCren3Id { get; set; }

    public string? Cg062CtagerencialCren4Id { get; set; }

    public CSICP_CG005? NavCG005HistDeb_CG062 { get; set; }
    public CSICP_CG005? NavCG005HistCred_CG062 { get; set; }
    public CSICP_CG006? NavCG006ContaDeb_CG062 { get; set; }
    public CSICP_CG006? NavCG006ContaCred_CG062 { get; set; }
    public Osusr8dwCsicpCg060? NavCG060RegramentoID_CG062 { get; set; }
    public Osusr8dwCsicpCg054? NavCG054EventoValorTpID_CG062 { get; set; }
    public Osusr8dwCsicpCg054? NavCG054EventoValorTpDebID_CG062 { get; set; }
    public Osusr8dwCsicpCg054? NavCG054EventoValorTpCredID_CG062 { get; set; }

}
