using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD153
{
    public int TenantId { get; set; }

    public int Dd153Id { get; set; }

    public int? Dd150Id { get; set; }

    public string? Dd153Montadorid { get; set; }

    public DateTime? Dd153Dagenda { get; set; }

    public DateTime? Dd153Hora { get; set; }

    public bool? Dd153Isactive { get; set; }

    public string? Dd153Usuariopropid { get; set; }

    public DateTime? Dd153Dregistro { get; set; }

    public long? Dd160Perfilid { get; set; }

    public virtual CSICP_DD150? Dd150 { get; set; }

    public virtual CSICP_DD158? Dd153Montador { get; set; }
}
