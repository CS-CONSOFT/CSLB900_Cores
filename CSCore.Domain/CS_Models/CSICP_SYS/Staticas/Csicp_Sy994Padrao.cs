namespace CSCore.Domain;

public partial class Csicp_Sy994Padrao
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public string? Descritivo { get; set; }

    public ICollection<Csicp_Sy994> OsusrE9aCsicpSy994s { get; set; } = new List<Csicp_Sy994>();
}
