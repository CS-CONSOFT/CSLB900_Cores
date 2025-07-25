namespace CSCore.Domain;

public partial class CSICP_AA030Regime
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public string? CrtDigito { get; set; }

    // public  ICollection<CSICP_BB001Cfgfi> OsusrE9aCsicpBb001Cfgfis { get; set; } = new List<CSICP_BB001Cfgfi>();
}
