using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG073
{
    public int TenantId { get; set; }

    public string Gg073Id { get; set; } = null!;

    public string? Gg073Estabid { get; set; }

    public DateTime Gg073DataMovimento { get; set; } = default!;

    public string? Gg073Usuarioid { get; set; }

    public string? Gg073Observacao { get; set; }

    public string? Gg073Ccustoid { get; set; }

    public string? Gg073Almoxmovd { get; set; }

    public DateTime? Gg073Dhregistro { get; set; }

    public int? Gg073Statusid { get; set; }

    public int? Gg073Tmovid { get; set; }

    public int? Gg073Valorizarporid { get; set; }

    public decimal? Gg073Tmovimento { get; set; }

    public string? Gg073Protocolonro { get; set; }

    public string? Gg073Almoxmovsaida { get; set; }

    public long? Gg073QtdeItens { get; set; }

    public string? Gg073IdOrig { get; set; }

    public long? Dd190Obraid { get; set; }

    public CSICP_GG001? Gg073AlmoxmovdNavigation { get; set; }

    public CSICP_GG001? Gg073AlmoxmovsaidaNavigation { get; set; }

    public OsusrE9aCsicpGg073Stat? Gg073Status { get; set; }

    public OsusrE9aCsicpGg073Tmov? Gg073Tmov { get; set; }

    public CSICP_GG023Val? Gg073Valorizarpor { get; set; }
    public Csicp_Sy001? NavSY001 { get; set; }
    public CSICP_Bb005? NavBB005 { get; set; }
}
