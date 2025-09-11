using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG054
{
    public int TenantId { get; set; }

    public long Gg054Id { get; set; }

    public string Gg054Filialid { get; set; } = string.Empty;

    public string? Gg054Protocolnumber { get; set; }

    public string? Gg054UsuarioId { get; set; }

    public DateTime? Gg054DataColeta { get; set; }

    public string? Gg054Observacao { get; set; }

    public int? Gg054Status { get; set; }

    public string? Gg054Almox { get; set; }

    public DateTime? Gg054DataInc { get; set; }

    public DateTime? Gg054HoraInc { get; set; }

    public DateTime? Gg054DataAlt { get; set; }

    public DateTime? Gg054HoraAlt { get; set; }

    public string? Gg054UsuarioAlt { get; set; }

    public string? Gg032Id { get; set; }

    public string Gg054DocInvent { get; set; } = string.Empty;

    public bool? Gg054Ismarcado { get; set; }

    public OsusrE9aCsicpGg054Stum? Gg054StatusNavigation { get; set; }

    public CSICP_GG001? NavGG001Almox { get; set; }

    public CSICP_GG055? NavProdutosColetaGG055 { get; set; }
}
