namespace CSCore.Domain.CS_Models.CSICP_SYS;

public partial class CsicpSy904Prg
{
    public string Id { get; set; } = null!;

    public string? Label { get; set; }

    public string? Programa { get; set; }

    public int? Ordem { get; set; }

    public string? SpacenameId { get; set; }

    public string? Url { get; set; }

    public string? Descricao { get; set; }

    public string? Cor { get; set; }

    public string? Dimensao { get; set; }

    public string? Fonticon { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Datacreate { get; set; }

    public int? Nivelprograma { get; set; }

    public int? IdSy804 { get; set; }

    public int? PropCsSisproId { get; set; }

    public string? LabelEnglish { get; set; }

    public string? DescricaoEnglish { get; set; }

    public string? LabelSpanish { get; set; }

    public string? DescricaoSpanish { get; set; }

    public string? Categoriaid { get; set; }

    public int? Menutipo { get; set; }

    //public CsicpSy905Smprg NavSY905SMprg { get; set; } = null!;
}
