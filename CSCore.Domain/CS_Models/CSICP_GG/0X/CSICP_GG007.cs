using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG007
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Gg007Filial { get; set; }

    public string? Gg007Filialid { get; set; }

    public string? Gg007Unidade { get; set; }

    public string? Gg007Descricao { get; set; }

    public bool? Gg007IsActive { get; set; }

    public int? Gg007FormavendaId { get; set; }

    public string? Gg007Qdecimais { get; set; }
    public CSICP_BB001? NavGg007Filial { get; set; }
    public OsusrE9aCsicpGg007Fra? NavGG007FraFormaVenda { get; set; }

}
