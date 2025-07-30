using CSCore.Domain.CS_Models.CSICP_DD;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD132
{
    public int TenantId { get; set; }

    public string Dd132Id { get; set; } = null!;

    public string? Dd132EstabId { get; set; }

    public string? Dd040Id { get; set; }

    public string? Dd060Id { get; set; }

    public string? Dd042Id { get; set; }

    public int? Dd132Sequencia { get; set; }

    public string? Ff103Id { get; set; }

    public int? Dd150Id { get; set; }

    public int? Dd132SeqBaixa { get; set; }

    public DateTime? Dd132DataCalculo { get; set; }

    public decimal? Dd132ValorBaixa { get; set; }

    public decimal? Dd132PercComissao { get; set; }

    public decimal? Dd132ValorComissao { get; set; }

    public int? Dd132Status { get; set; }

    public int? Dd132TipoMovto { get; set; }

    public string? Dd132UsuarioId { get; set; }

    public string? Dd132ResponsavelId { get; set; }

    public string? Dd132ArquitetoId { get; set; }

    public string? Dd132MontadorId { get; set; }

    public string? Dd136Id { get; set; }

    public bool? Dd132Ispagarcomissao { get; set; }

    public decimal? Dd132Vbasecomissao { get; set; }

    public string? Dd132IdPai { get; set; }

    public int? Dd132Tpcomissaoid { get; set; }

    public decimal? Dd132ValorComissaoUnit { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD042? Dd042 { get; set; }

    public virtual CSICP_DD060? Dd060 { get; set; }

    public virtual CSICP_DD158? Dd132Montador { get; set; }

    public virtual CSICP_DD132Status? Dd132StatusNavigation { get; set; }

    public virtual CSICP_DD131Tpmovto? Dd132TipoMovtoNavigation { get; set; }

    public virtual CSICP_DD136Tp? Dd132Tpcomissao { get; set; }

    public virtual CSICP_DD136? Dd136 { get; set; }

    public virtual CSICP_DD150? Dd150 { get; set; }
}
