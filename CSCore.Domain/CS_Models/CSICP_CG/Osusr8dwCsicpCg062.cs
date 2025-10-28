using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg062
{
    public int TenantId { get; set; }

    public long Cg062Id { get; set; }

    public long? Cg062Regramentoid { get; set; }

    public long? Cg062Eventovalortpid { get; set; }

    public string? Cg062Contadebid { get; set; }

    public string? Cg062Histdebid { get; set; }

    public string? Cg062Contacredid { get; set; }

    public string? Cg062Histcredid { get; set; }

    public long? Cg062Eventovalortpdebid { get; set; }

    public long? Cg062Eventovalortpcredid { get; set; }

    public bool? Cg062Isignorevalor { get; set; }

    public string? Cg062CtagerencialDebn2Id { get; set; }

    public string? Cg062CtagerencialDebn3Id { get; set; }

    public string? Cg062CtagerencialDebn4Id { get; set; }

    public string? Cg062CtagerencialCren2Id { get; set; }

    public string? Cg062CtagerencialCren3Id { get; set; }

    public string? Cg062CtagerencialCren4Id { get; set; }

    public virtual Osusr8dwCsicpCg006? Cg062Contacred { get; set; }

    public virtual Osusr8dwCsicpCg006? Cg062Contadeb { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg062CtagerencialCren2 { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg062CtagerencialCren3 { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg062CtagerencialCren4 { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg062CtagerencialDebn2 { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg062CtagerencialDebn3 { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg062CtagerencialDebn4 { get; set; }

    public virtual Osusr8dwCsicpCg054? Cg062Eventovalortp { get; set; }

    public virtual Osusr8dwCsicpCg054? Cg062Eventovalortpcred { get; set; }

    public virtual Osusr8dwCsicpCg054? Cg062Eventovalortpdeb { get; set; }

    public virtual Osusr8dwCsicpCg005? Cg062Histcred { get; set; }

    public virtual Osusr8dwCsicpCg005? Cg062Histdeb { get; set; }

    public virtual Osusr8dwCsicpCg060? Cg062Regramento { get; set; }
}
