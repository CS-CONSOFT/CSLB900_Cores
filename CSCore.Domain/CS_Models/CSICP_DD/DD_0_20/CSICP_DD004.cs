using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD004
{
    public int TenantId { get; set; }

    public string Dd004Id { get; set; } = null!;

    public string? Dd001Id { get; set; }

    public string? Dd004Empresaid { get; set; }

    public string? Dd004Descricao { get; set; }

    public string? Dd004ContaId { get; set; }

    public string? Dd004FormapagtoId { get; set; }

    public string? Dd004RotaId { get; set; }

    public string? Dd004CategoriaId { get; set; }

    public decimal? Dd004Percentual { get; set; }

    public decimal? Dd004ValorAcrescimo { get; set; }

    public DateTime? Dd004DataValidade { get; set; }

    public bool? Dd004DescontoFlexivel { get; set; }

    public string? Dd004Protocolnumber { get; set; }

    public virtual CSICP_DD001? Dd001 { get; set; }
}
