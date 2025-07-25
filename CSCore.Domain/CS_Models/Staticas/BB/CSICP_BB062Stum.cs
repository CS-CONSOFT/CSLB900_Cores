namespace CSCore.Domain;

public partial class CSICP_Bb062Stum
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public ICollection<CSICP_Bb062> OsusrE9aCsicpBb062s { get; set; } = new List<CSICP_Bb062>();
}
