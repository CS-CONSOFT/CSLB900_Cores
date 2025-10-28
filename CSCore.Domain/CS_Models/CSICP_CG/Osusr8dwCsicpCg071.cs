using CSCore.Domain.CS_Models.Staticas.CG;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg071
{
    public int TenantId { get; set; }

    public long Cg071Id { get; set; }

    public string? Cg071Estabdebid { get; set; }

    public string? Cg071Estabcredid { get; set; }

    public long? Cg071Conteventoid { get; set; }

    public string? Cg071Idlancamento { get; set; }

    public DateTime? Cg071Dtcontabil { get; set; }

    public string? Cg071Txdocumento { get; set; }

    public string? Cg071Txcomplemento { get; set; }

    public string? Cg071Idorigem { get; set; }

    public string? Cg071Infrausuarioid { get; set; }

    public int? Cg071Continstatusinterid { get; set; }

    public long? Cg071Protocolocontabilizaca { get; set; }

    public int? Cg071Version { get; set; }

    public long? Cg071Protocoloprovisaoid { get; set; }

    public virtual Osusr8dwCsicpCg050? Cg071Contevento { get; set; }

    public virtual Osusr8dwCsicpCg070Stum? Cg071Continstatusinter { get; set; }

    public virtual Osusr8dwCsicpCg070? Cg071ProtocolocontabilizacaNavigation { get; set; }

    public virtual ICollection<Osusr8dwCsicpCg072> Osusr8dwCsicpCg072s { get; set; } = new List<Osusr8dwCsicpCg072>();

    public virtual ICollection<Osusr8dwCsicpCg073> Osusr8dwCsicpCg073s { get; set; } = new List<Osusr8dwCsicpCg073>();
}
