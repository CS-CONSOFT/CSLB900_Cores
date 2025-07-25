using CSCore.Domain.CS_Models.Staticas.GG;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg058
{
    public int TenantId { get; set; }

    public string Gg058Id { get; set; } = null!;

    public string? Gg058FilialId { get; set; }

    public DateTime? Gg058Data { get; set; }

    public string? Gg058KardexId { get; set; }

    public decimal? Gg058Vprcvenda { get; set; }

    public decimal? Gg058Tprcvenda { get; set; }

    public decimal? Gg058Tprccusto { get; set; }

    public decimal? Gg058Tprccustoreal { get; set; }

    public DateTime? Gg058Dtinicio { get; set; }

    public DateTime? Gg058Dtfim { get; set; }

    public bool? Gg058Isactive { get; set; }

    public int? Gg058Protocolnumber { get; set; }

    public CSICP_GG008Kdx? Gg058Kardex { get; set; }

    public ICollection<OsusrE9aCsicpGg059> OsusrE9aCsicpGg059s { get; set; } = new List<OsusrE9aCsicpGg059>();
}
