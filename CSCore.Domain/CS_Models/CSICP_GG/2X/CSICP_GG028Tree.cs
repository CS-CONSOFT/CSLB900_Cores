namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG028Tree
{
    public int TenantId { get; set; }

    public string Gg028TreeId { get; set; } = null!;

    public string? Gg028DoctoId { get; set; }

    public string? Gg028DoctoProtocolnumber { get; set; }

    public int? Gg028DoctoTipo { get; set; }

    public string? Gg028DoctoParentId { get; set; }

    public DateTime? Gg028Datahora { get; set; }

    //public OsusrE9aCsicpGg028Nat? Gg028DoctoTipoNavigation { get; set; }
}
