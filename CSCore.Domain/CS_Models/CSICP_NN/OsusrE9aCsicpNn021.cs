using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class OsusrE9aCsicpNn021
{
    public int TenantId { get; set; }

    public int Nn021Id { get; set; }

    public int? Nn020Id { get; set; }

    public string? Nn021Trntype { get; set; }

    public string? Nn021Dtposted { get; set; }

    public DateTime? Nn021Dpostagem { get; set; }

    public decimal? Nn021Trnamt { get; set; }

    public string? Nn021Fitid { get; set; }

    public string? Nn021Checknum { get; set; }

    public string? Nn021Memo { get; set; }

    public string? Nn010Id { get; set; }

    public bool? Nn021Isrepetido { get; set; }

    public virtual OsusrE9aCsicpNn010? Nn010 { get; set; }

    public virtual OsusrE9aCsicpNn020? Nn020 { get; set; }
}
