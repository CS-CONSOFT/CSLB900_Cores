using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg046
{
    public int TenantId { get; set; }

    public string Gg046Id { get; set; } = null!;

    public int? Gg046Seq { get; set; }

    public string? Gg045Id { get; set; }

    public string? Gg046SaldoentId { get; set; }

    public decimal? Gg046Qtd { get; set; }

    public int? Gg046StatId { get; set; }

    public int? Gg046EntsaiId { get; set; }

    public bool? Gg046Isnovo { get; set; }

    public string? Gg046Descricaosaldo { get; set; }

    public string? Gg046Codbarrasalfa { get; set; }

    public CSICP_GG045? Gg045 { get; set; }

    public OsusrE9aCsicpGg046E? Gg046Entsai { get; set; }

    public CSICP_GG520? Nav_Gg250Saldoent { get; set; }

    public OsusrE9aCsicpGg045Stat? Gg046Stat { get; set; }
}
