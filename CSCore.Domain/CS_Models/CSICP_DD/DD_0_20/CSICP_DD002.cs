using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD002
{
    public int TenantId { get; set; }

    public string Dd002Id { get; set; } = null!;

    public string? Dd001Id { get; set; }

    public string? Dd002Empresaid { get; set; }

    public string? Dd002Descricao { get; set; }

    public string? Dd002ContaId { get; set; }

    public string? Dd002FormapagtoId { get; set; }

    public string? Dd002RotaId { get; set; }

    public string? Dd002CategoriaId { get; set; }

    public decimal? Dd002Percentual { get; set; }

    public decimal? Dd002ValorDesconto { get; set; }

    public DateTime? Dd002DataValidade { get; set; }

    public bool? Dd002DescontoFlexivel { get; set; }

    public string? Dd002Protocolnumber { get; set; }

    public decimal? Dd002Valoracimade { get; set; }

    public virtual CSICP_DD001? Dd001 { get; set; }
}
