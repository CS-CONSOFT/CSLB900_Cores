namespace CSCore.Domain;

public partial class CSICP_Aa040
{
    public int TenantId { get; set; }

    public string Aa040Id { get; set; } = null!;

    public string? Aa040UforigemId { get; set; }

    public string? Aa040UfdestinoId { get; set; }

    public decimal? Aa040Paliquota { get; set; }

    //public CSICP_Aa027? Aa040Ufdestino { get; set; }

    //public CSICP_Aa027? Aa040Uforigem { get; set; }
}
