namespace CSCore.Domain;

public partial class CSICP_Bb037
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Bb037Codigo { get; set; }

    public string? Bb037Descricao { get; set; }

    public int? Bb037Dia { get; set; }

    public int? Bb037Qtddiasmcompra { get; set; }

    public bool? Bb037Isactive { get; set; }

    //public ICollection<CSICP_Bb062> OsusrE9aCsicpBb062s { get; set; } = new List<CSICP_Bb062>();
}
