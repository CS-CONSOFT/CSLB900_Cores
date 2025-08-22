using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG045
{
    public int TenantId { get; set; }

    public string Gg045Id { get; set; } = null!;

    public string? Gg045EstabelecimentoId { get; set; }

    public string? Gg045Saldoid { get; set; }

    public decimal? Gg045Qtd { get; set; }

    public string? Gg045Protocolnumber { get; set; }

    public DateTime? Gg045Datamovto { get; set; }

    public string? Gg045UsuariopropId { get; set; }

    public string? Gg045Descricao { get; set; }

    public string? Cc040Id { get; set; }

    public int? Gg045Statid { get; set; }

    public string? Cc060Id { get; set; }

    public CSICP_GG520? Gg045Saldo { get; set; }

    public OSUSR_E9A_CSICP_GG045_STAT? Gg045Stat { get; set; }
}
