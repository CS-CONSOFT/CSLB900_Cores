using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD012
{
    public int TenantId { get; set; }

    public long Dd012Id { get; set; }

    public string? Dd012EstabId { get; set; }

    public string? Dd012Descricao { get; set; }

    public string? Dd012Header { get; set; }

    public string? Dd012Main { get; set; }

    public string? Dd012Footer { get; set; }

    public bool? Dd012Isactive { get; set; }

    public int? Dd012Tpmodeloid { get; set; }

    public virtual CSICP_DD012Tp? Dd012Tpmodelo { get; set; }
}
