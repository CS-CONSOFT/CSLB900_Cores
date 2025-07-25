using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG008i
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg008iFilialid { get; set; }

    public string? Gg008iKardexId { get; set; }

    public string? Gg008iProdutoid { get; set; }

    public string? Gg008iTransacaoid { get; set; }

    public int? Gg008iTiporegistro { get; set; }

    public string? Gg008iNcmId { get; set; }

    public CSICP_Bb027? NavBB027Transacao { get; set; }
    public OsusrE9aCsicpGg008Tran? NavGG008Trans { get; set; }
}
