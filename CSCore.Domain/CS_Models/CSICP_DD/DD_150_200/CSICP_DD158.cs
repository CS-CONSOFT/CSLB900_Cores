using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD158
{
    public int TenantId { get; set; }

    public string Dd158Id { get; set; } = null!;

    public string? Dd158Nomemontador { get; set; }

    public string? Sy001Usuarioid { get; set; }

    public decimal? Dd158Pcomissao { get; set; }

    public decimal? Dd158Pcomissao2 { get; set; }

    public bool? Dd158Isactive { get; set; }

    public string? Dd158Contafornid { get; set; }

    public int? Dd158Intextid { get; set; }

    public long? Dd160Perfilid { get; set; }

    public virtual CSICP_DD158Tp? Dd158Intext { get; set; }

    public virtual CSICP_DD160? Dd160Perfil { get; set; }
}
