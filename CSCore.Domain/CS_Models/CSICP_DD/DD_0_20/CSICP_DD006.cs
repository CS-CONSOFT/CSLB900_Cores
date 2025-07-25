using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD006
{
    public int TenantId { get; set; }

    public string Dd006Id { get; set; } = null!;

    public string? Dd006Empresaid { get; set; }

    public string? Dd006ProdutoId { get; set; }

    public decimal? Dd006Precovenda { get; set; }

    public decimal? Dd006Percdesconto { get; set; }

    public decimal? Dd006Precopromocao { get; set; }

    public string? Dd006AlmoxId { get; set; }

    public bool? Dd006Isactive { get; set; }

    public string? Dd001Rcomercializid { get; set; }

    public virtual CSICP_DD001? Dd001Rcomercializ { get; set; }
}
