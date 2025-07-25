using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF033
{
    public int TenantId { get; set; }

    public string Ff033Id { get; set; } = null!;

    public string? Ff032Id { get; set; }

    public string? Ff033Tituloadtoid { get; set; }

    public decimal? Ff033Vdeduzir { get; set; }

    public string? Ff033UsuarioInc { get; set; }

    public DateTime? Ff033Dinclusao { get; set; }

    public int? Ff033Statusid { get; set; }

    public string? Ff033Observacao { get; set; }

    public virtual CSICP_FF032? Ff032 { get; set; }

    public virtual CSICP_FF102? Ff033Tituloadto { get; set; }
}
