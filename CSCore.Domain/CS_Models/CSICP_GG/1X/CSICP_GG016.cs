namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG016
{
    public int? TenantId { get; set; }

    public string? Id { get; set; } = string.Empty;

    public string? Gg016Filialid { get; set; }

    public int? Gg016Filial { get; set; }

    public string? Gg016Grade { get; set; }

    public string? Gg016Descricao { get; set; }

    public int? Gg016Lincolid { get; set; }

    public bool? Gg016Ismarcado { get; set; }
    public CSICP_BB001? NavFilialBB001 { get; set; }
    public CSICP_GG016b? NavCSICP_GG016b { get; set; }
}
