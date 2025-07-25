using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD136
{
    public int TenantId { get; set; }

    public string Dd136Id { get; set; } = null!;

    public string? Dd136EstabelecimentoId { get; set; }

    public DateTime? Dd136Dinicioperiodo { get; set; }

    public DateTime? Dd136Dfimperiodo { get; set; }

    public string? Dd136Protocolnumber { get; set; }

    public bool? Dd136Isaberto { get; set; }

    public string? Dd136Descricao { get; set; }

    public DateTime? Dd136Dinclusao { get; set; }

    public string? Dd136Userpropid { get; set; }

    public DateTime? Dd136DataRef { get; set; }

    public int? Dd136Tpcomissaoid { get; set; }

    public virtual CSICP_DD136Tp? Dd136Tpcomissao { get; set; }
}
