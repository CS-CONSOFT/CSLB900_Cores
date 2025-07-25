using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF111
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff110Id { get; set; }

    public string? Ff102Tituloid { get; set; }

    public DateTime? Ff111Dataregistro { get; set; }

    public decimal? Ff111Ptaxaantecipacao { get; set; }

    public decimal? Ff111Ptaxaoriginal { get; set; }

    public decimal? Ff111Vantecipacao { get; set; }

    public virtual CSICP_FF102? Ff102Titulo { get; set; }

    public virtual CSICP_FF110? Ff110 { get; set; }
}
