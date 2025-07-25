namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG010
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Gg010Filial { get; set; }

    public string? Gg010Filialid { get; set; }

    public string? Gg010CodigoTipopadrao { get; set; }

    public string? Gg010Descricaotipopadrao { get; set; }

    public bool? Gg010IsActive { get; set; }

    public CSICP_BB001? NavFilial { get; set; }
}
