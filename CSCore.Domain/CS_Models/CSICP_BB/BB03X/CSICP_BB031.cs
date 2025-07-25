namespace CSCore.Domain;

public partial class CSICP_Bb031
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb031Codgfuncaoid { get; set; }

    public string? Bb031Descricao { get; set; }

    public string? Bb031Cbo { get; set; }

    public bool? Bb031Isactive { get; set; }

    //public ICollection<CSICP_BB007> OsusrE9aCsicpBb007s { get; set; } = new List<CSICP_BB007>();
}
