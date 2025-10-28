using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg074
{
    public int TenantId { get; set; }

    public long Cg074Id { get; set; }

    public long? Cg072Id { get; set; }

    public decimal? Cg074Valor { get; set; }

    public int? Cg074Debcre { get; set; }

    public long? Cg060Regramentoid { get; set; }

    public string? Cg021Lanctocontabilid { get; set; }

    public string? Cg074ContacontabilId { get; set; }

    public string? Cg074CtagerencialN2Id { get; set; }

    public string? Cg074CtagerencialN3Id { get; set; }

    public string? Cg074CtagerencialN4Id { get; set; }

    public virtual Osusr8dwCsicpCg021? Cg021Lanctocontabil { get; set; }

    public virtual Osusr8dwCsicpCg060? Cg060Regramento { get; set; }

    public virtual Osusr8dwCsicpCg072? Cg072 { get; set; }

    public virtual Osusr8dwCsicpCg006? Cg074Contacontabil { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg074CtagerencialN2 { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg074CtagerencialN3 { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg074CtagerencialN4 { get; set; }

    public virtual Osusr8dwCsicpCg993? Cg074DebcreNavigation { get; set; }
}
