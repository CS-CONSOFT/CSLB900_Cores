using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG008c
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg008cFilialid { get; set; }

    public string? Gg008cProdutoid { get; set; }

    public int? Gg008cFilial { get; set; }

    public int? Gg008cCodgproduto { get; set; }

    public string? Gg008cDescricao { get; set; }

    public int? Gg008cOrdem { get; set; }

    public string? Gg008cTiporegistro { get; set; }

    public byte[]? Gg008cObjeto { get; set; }

    public string? Gg008cFiletype { get; set; }

    public string? Gg008cTexto { get; set; }

    public string? Filename { get; set; }

    public bool? Gg008cIspadrao { get; set; }

    public string? Gg008cPath { get; set; }

    public int? Gg008cSize { get; set; }

    public int? Gg008cCdnid { get; set; }

    public OsusrE9aCsicpGg008Cdn? Gg008cCdn { get; set; }

    //public CSICP_GG008? Gg008cProduto { get; set; }
}
