namespace CSCore.Domain.CS_Models.CSICP_SYS;

public partial class CsicpSy905Smprg
{
    public string Id { get; set; } = null!;

    public string? Submenu { get; set; }

    public string? Programa { get; set; }

    public string? Label { get; set; }

    public int? Ordem { get; set; }

    public bool? IsActive { get; set; }

    public int? IdSy805 { get; set; }

    public int? PropCsSisproId { get; set; }

    public CsicpSy904Prg NavPrograma { get; set; } = null!;
}
