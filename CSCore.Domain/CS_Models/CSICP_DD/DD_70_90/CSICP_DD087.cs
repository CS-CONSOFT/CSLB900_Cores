using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD087
{
    public int TenantId { get; set; }

    public string Dd087Id { get; set; } = null!;

    public string? Dd085Id { get; set; }

    public string? Dd087UsuarioproprId { get; set; }

    public DateTime? Dd087Dataaprovacao { get; set; }

    public string? Dd087Observacao { get; set; }

    public int? Dd087SituacaoId { get; set; }

    public bool? Dd087Isactive { get; set; }

    public string? Dd087Protocolnumber { get; set; }

    public virtual CSICP_DD085? Dd085 { get; set; }

    public virtual CSICP_DD087Lib? Dd087Situacao { get; set; }
}
