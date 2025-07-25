using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD079
{
    public int TenantId { get; set; }

    public string Dd079Id { get; set; } = null!;

    public string? Dd070Id { get; set; }

    public string? Dd079EstacaoId { get; set; }

    public string? Dd079CaixaId { get; set; }

    public int? Dd079EventoId { get; set; }

    public string? Dd079Nomeevento { get; set; }

    public DateTime? Dd079Datacreate { get; set; }

    public string? Dd079Usuarioid { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }

    public virtual CSICP_DD079Evento? Dd079Evento { get; set; }
}
