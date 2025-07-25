namespace CSCore.Domain.CS_Models.CSICP_SYS;

public partial class CsicpSy903Smenu
{
    public string Id { get; set; } = null!;

    public string? Label { get; set; }

    public string? Descricao { get; set; }

    public string? Submenu { get; set; }

    public string? Url { get; set; }

    public string? Menu { get; set; }

    public string? Dimensao { get; set; }

    public string? Cor { get; set; }

    public string? Fonticon { get; set; }

    public int? Ordem { get; set; }

    public DateTime? Datacreate { get; set; }

    public bool? Isactive { get; set; }

    public int? IdSy803 { get; set; }

    public int? PropCsSisproId { get; set; }

    public string? LabelEnglish { get; set; }

    public string? DescricaoEnglish { get; set; }

    public string? LabelSpanish { get; set; }

    public string? DescricaoSpanish { get; set; }

    public string? Categoriaid { get; set; }

    public int? Menutipo { get; set; }

    public List<CsicpSy905Smprg> ListaSubMenuProgramas { get; set; } = [];
    //public List<Csicp_Sy015> Lista_CSICP_SY015 { get; set; } = [];
}
