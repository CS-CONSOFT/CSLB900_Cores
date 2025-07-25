namespace CSCore.Domain;

public partial class CSICP_AA006
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Aa006Filial { get; set; }

    public string? Aa006Arquivo { get; set; }

    public decimal? Aa006Ci { get; set; }

    public string? Aa006Filialid { get; set; }

    public DateTime? Aa006Dataultcaptura { get; set; }

    public int? Aa006Circular { get; set; }

    public decimal? Aa006Maxcircular { get; set; }

    public CSICP_Statica? Aa006CircularNavigation { get; set; }

    public CSICP_BB001? FilialBB001 { get; set; }
}
