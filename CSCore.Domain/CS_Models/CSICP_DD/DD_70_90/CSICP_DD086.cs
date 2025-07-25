using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD086
{
    public int TenantId { get; set; }

    public string Dd086Id { get; set; } = null!;

    public string? Dd085Id { get; set; }

    public string? Dd086Responsavel { get; set; }

    public DateTime? Dd086Dataconsulta { get; set; }

    public string? Dd086Orgaoconsulta { get; set; }

    public string? Dd086Observacao { get; set; }

    public int? Dd086SituacaoId { get; set; }

    public int? Dd086Tipoconsulta { get; set; }

    public bool? Dd086Isactive { get; set; }

    public string? Dd086UsuarioproprId { get; set; }

    public string? Dd086Protocolnumber { get; set; }

    public virtual CSICP_DD085? Dd085 { get; set; }

    public virtual CSICP_DD086Constum? Dd086Situacao { get; set; }

    public virtual CSICP_DD086Tpcon? Dd086TipoconsultaNavigation { get; set; }
}
