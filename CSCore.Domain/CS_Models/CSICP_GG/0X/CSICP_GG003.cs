namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG003
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Gg003Filial { get; set; }

    public string? Gg003Filialid { get; set; }

    public int? Gg003Codigogrupo { get; set; }

    public string? Gg003Descgrupo { get; set; }

    public decimal? Gg003Plucro { get; set; }

    public bool? Gg003Isactive { get; set; }

    public bool? Gg003Isvisivelcompra { get; set; }

    public bool? Gg003Isvisivelvenda { get; set; }

    public int? Gg003Ordemconsulta { get; set; }

    public string? Gg003Iconegrupoproduto { get; set; }

    public bool? Gg003Isexibepdv { get; set; }
}

