namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG022
{
    public int TenantId { get; set; }

    public string Gg022Id { get; set; } = null!;

    public string? Gg022Ncmid { get; set; }

    public string? Gg022Ufid { get; set; }

    public decimal? Gg022Pfcp { get; set; }

    public CSICP_GG021? NavGg021Ncm { get; set; }
}
