namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG013
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Gg013Filial { get; set; }

    public string? Gg013Filialid { get; set; }

    public string? Gg013Aplicacao { get; set; }

    public CSICP_GG008 Nav_GG008 { get; set; } = null!;
}
