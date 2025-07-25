using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG001
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Gg001Filial { get; set; }

    public string? Gg001Filialid { get; set; }

    public int? Gg001Codigoalmox { get; set; }

    public string? Gg001Descalmox { get; set; }

    public bool? Gg001Isactive { get; set; }

    public int? Gg001Tipoalmoxarifado { get; set; }

    public bool? Gg001RiControlequalidade { get; set; }

    public decimal? Gg001Caparmaz { get; set; }

    public string? Gg001Descnspadrao { get; set; }

    public CSICP_GG001Talmox? Gg001TipoalmoxarifadoNavigation { get; set; }
    public CSICP_BB001? BB001FilialNav { get; set; }
}
