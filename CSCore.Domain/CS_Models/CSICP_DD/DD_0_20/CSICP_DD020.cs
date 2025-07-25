using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD020
{
    public int TenantId { get; set; }

    public string Dd020Id { get; set; } = null!;

    public string? Dd020Estabelecimentoid { get; set; }

    public string? Dd020Protocolnumber { get; set; }

    public string? Dd020Descricao { get; set; }

    public string? Dd020Ano { get; set; }

    public string? Dd020Mes { get; set; }

    public decimal? Dd020Vtotalvenda { get; set; }

    public decimal? Dd020Vdevolucoes { get; set; }

    public string? Dd020Usuarioprop { get; set; }

    public DateTime? Dd020Dataregistro { get; set; }

    public int? Dd020StatusId { get; set; }

    public virtual CSICP_DD020Metum? Dd020Status { get; set; }
}
