using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg059
{
    public int TenantId { get; set; }

    public string Gg059Id { get; set; } = null!;

    public string? Gg058Id { get; set; }

    public decimal? Gg059Quantidade { get; set; }

    public decimal? Gg059Vprctabela { get; set; }

    public decimal? Gg059Pdesconto { get; set; }

    public decimal? Gg059Vdesconto { get; set; }

    public decimal? Gg059Vprcvenda { get; set; }

    public decimal? Gg059Tvendaliq { get; set; }

    public decimal? Gg059Tvendabru { get; set; }

    public decimal? Gg059Vcusto { get; set; }

    public decimal? Gg059Vcreal { get; set; }

    public decimal? Gg059Pparticipacao { get; set; }

    public OsusrE9aCsicpGg058? Gg058 { get; set; }
}
