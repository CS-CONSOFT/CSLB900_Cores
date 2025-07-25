namespace CSCore.Domain;

public partial class CSICP_Bb011
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb011Codigo { get; set; }

    public string? Bb011Atividade { get; set; }

    public bool? Bb011IsActive { get; set; }

    //public ICollection<CSICP_Bb036> OsusrE9aCsicpBb036s { get; set; } = new List<CSICP_Bb036>();
}
