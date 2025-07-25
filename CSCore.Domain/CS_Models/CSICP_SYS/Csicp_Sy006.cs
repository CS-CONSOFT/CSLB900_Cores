namespace CSCore.Domain;

public partial class Csicp_Sy006
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy006Userid { get; set; }

    public int? Sy006RegraestaticaId { get; set; }

    public Csicp_Sy003Regra? Sy006Regraestatica { get; set; }


}
