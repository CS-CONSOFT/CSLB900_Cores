namespace CSCore.Domain;

public partial class CSICP_Bb028b
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb028bFilial { get; set; }

    public int? Bb028bCodresponsavel { get; set; }

    public int? Bb028bCodigocliente { get; set; }

    public decimal? Bb028bPerccomissao { get; set; }

    public string? Bb028bCompradorId { get; set; }

    public string? Bb028bContaid { get; set; }

    public CSICP_BB012? NavBB012 { get; set; }
}
