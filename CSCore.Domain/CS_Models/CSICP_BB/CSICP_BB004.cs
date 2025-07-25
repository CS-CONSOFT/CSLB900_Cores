namespace CSCore.Domain;

public partial class CSICP_BB004
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb004Codigo { get; set; }

    public DateTime? Bb004Datacambio { get; set; }

    public decimal? Bb004Valorcambio { get; set; }

    public string? Moedaid { get; set; }

    //public CSICP_Bb003? Moeda { get; set; }
}
