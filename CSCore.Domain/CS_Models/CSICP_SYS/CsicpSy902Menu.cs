namespace CSCore.Domain.CS_Models.CSICP_SYS;

public partial class CsicpSy902Menu
{
    public string Id { get; set; } = null!;

    public int? IdSy802 { get; set; }

    public string? Label { get; set; }

    public string? Menu { get; set; }

    public string? Descricao { get; set; }

    public string? Url { get; set; }

    public int? Ordem { get; set; }

    public DateTime? Datacreate { get; set; }

    public string? Dimensoes { get; set; }

    public string? Fonticon { get; set; }

    public string? Cor { get; set; }

    public bool? Isactive { get; set; }

    public int? PropCsSisproId { get; set; }

    public string? LabelEnglish { get; set; }

    public string? DescricaoEnglish { get; set; }

    public string? LabelSpanish { get; set; }

    public string? DescricaoSpanish { get; set; }

    public string? Categoriaid { get; set; }

    public int? Menutipo { get; set; }

    public List<CsicpSy903Smenu> ListaSubmenus { get; set; } = [];

    //public List<Csicp_Sy014> ListCSICP_Sy014 { get; set; } = [];
}
