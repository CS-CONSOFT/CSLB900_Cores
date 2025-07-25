using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD205
{
    public int TenantId { get; set; }

    public long Dd205Id { get; set; }

    public long? Dd205Obraid { get; set; }

    public string? Dd205Ocorrencia { get; set; }

    public DateTime? Dd205Datahorainc { get; set; }

    public int? Dd205Statid { get; set; }

    public string? Dd205Usuariopropid { get; set; }

    public string? Dd205Responsavel { get; set; }

    public virtual CSICP_DD190? Dd205Obra { get; set; }

    public virtual CSICP_DD205Stat? Dd205Stat { get; set; }
}
