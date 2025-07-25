namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG004
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Gg004Filial { get; set; }

    public string? Gg004Filialid { get; set; }

    public int? Gg004Codigoclasse { get; set; }

    public string? Gg004Descclasse { get; set; }

    public bool? Gg004Isactive { get; set; }

    public CSICP_BB001? NavBB001Filial { get; set; } = null;

    //public ICollection<OsusrE9aCsicpGg008> OsusrE9aCsicpGg008s { get; set; } = new List<OsusrE9aCsicpGg008>();
}
