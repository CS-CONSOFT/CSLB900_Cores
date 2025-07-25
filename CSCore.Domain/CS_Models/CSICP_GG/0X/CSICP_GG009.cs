namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG009
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Gg009Filial { get; set; }

    public string? Gg009Filiald { get; set; }

    public string? Gg009Codigopadrao { get; set; }

    public string? Gg009Descpadrao { get; set; }

    public bool? Gg009IsActive { get; set; }

    public CSICP_GG001? NavFilialBB001 { get; set; }
}
