namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD142
{
    public int TenantId { get; set; }

    public long Dd142Id { get; set; }

    public DateTime? Dd142Dtregistro { get; set; }

    public DateTime? Dd142Dhregistro { get; set; }

    public string? Bb012Id { get; set; }

    public string? Dd040Id { get; set; }

    public int? Dd142Statusid { get; set; }

    public string? Dd142Cartacreditoid { get; set; }

    public decimal? Dd142Vcashback { get; set; }

    public DateTime? Dd142Dtliberacao { get; set; }

    public string? Dd142HashCalculador { get; set; }

    public CSICP_DD040? Nav_Dd040 { get; set; }
    public CSICP_BB012? Nav_BB012 { get; set; }

    public CSICP_DD143Stum? Nav_Dd143Status { get; set; }
}
