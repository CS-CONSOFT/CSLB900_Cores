using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD016
{
    public int TenantId { get; set; }

    public string Dd016Id { get; set; } = null!;

    public string? Dd016FilialId { get; set; }

    public string? Dd016FormapagtoId { get; set; }

    public string? Dd016CondicaoId { get; set; }

    public string? Dd016GrupoId { get; set; }

    public string? Dd016ClasseId { get; set; }

    public string? Dd016MarcaId { get; set; }

    public string? Dd016ArtigoId { get; set; }

    public decimal? Dd016PercentPvenda { get; set; }

    public decimal? Dd016PercentPedido { get; set; }

    public int? Dd016Aplicacao { get; set; }

    public bool? Dd016Isactive { get; set; }

    public string? Dd016Protocolnumber { get; set; }

    public string? Dd001Rcomercializid { get; set; }

    public virtual CSICP_DD001? Dd001Rcomercializ { get; set; }

    public virtual CSICP_DD016Apl? Dd016AplicacaoNavigation { get; set; }
}
