using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD107
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Dd107IdentCurto { get; set; }

    public string? Dd107IdentLongo { get; set; }

    public DateTime? Dd107Dtregistro { get; set; }

    public string? Dd107Proprietarioid { get; set; }

    public virtual ICollection<CSICP_DD101> OsusrTeiCsicpDd101s { get; set; } = new List<CSICP_DD101>();
}
