namespace CSCore.Domain;

public partial class CSICP_Bb003
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Bb003Moeda { get; set; }

    public string? Bb003Sigla { get; set; }

    //public ICollection<CSICP_BB004> BB004List { get; set; } = [];
}
