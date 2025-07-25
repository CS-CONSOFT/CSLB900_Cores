namespace CSCore.Domain;

public partial class CSICP_Bb009
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb009Filial { get; set; }

    public int? Bb009Codigo { get; set; }

    public string? Bb009Tipocobranca { get; set; }

    public string? Empresaid { get; set; }

    public bool? Bb009Isactive { get; set; }

    //public ICollection<CSICP_Bb006> OsusrE9aCsicpBb006s { get; set; } = new List<CSICP_Bb006>();

    //public ICollection<CSICP_Bb060> OsusrE9aCsicpBb060s { get; set; } = new List<CSICP_Bb060>();
}
