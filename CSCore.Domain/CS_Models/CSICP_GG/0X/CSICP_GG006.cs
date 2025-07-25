namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG006
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg006Filial { get; set; }

    public int? Gg006Codgfilial { get; set; }

    public int? Gg006Codigomarca { get; set; }

    public string? Gg006Descmarca { get; set; }

    public bool? Gg006IsActive { get; set; }

    //public ICollection<OsusrE9aCsicpGg008b> OsusrE9aCsicpGg008bs { get; set; } = new List<OsusrE9aCsicpGg008b>();

    //public ICollection<OsusrE9aCsicpGg008> OsusrE9aCsicpGg008s { get; set; } = new List<OsusrE9aCsicpGg008>();
}
