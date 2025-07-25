using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD018
{
    public int TenantId { get; set; }

    public string Dd018Id { get; set; } = null!;

    public string? Dd018Grupoformacao { get; set; }

    public string? Dd018FormapagtoId { get; set; }

    public string? Dd018CondicaoId { get; set; }

    public string? Dd018GrupoId { get; set; }

    public string? Dd018ClasseId { get; set; }

    public string? Dd018MarcaId { get; set; }

    public string? Dd018ArtigoId { get; set; }

    public decimal? Dd018PercentPvenda { get; set; }

    public decimal? Dd018PercentPedido { get; set; }

    public int? Dd018Aplicacao { get; set; }

    public bool? Dd018Isactive { get; set; }

    public virtual CSICP_DD016Apl? Dd018AplicacaoNavigation { get; set; }

    public virtual CSICP_DD017? Dd018GrupoformacaoNavigation { get; set; }
}
