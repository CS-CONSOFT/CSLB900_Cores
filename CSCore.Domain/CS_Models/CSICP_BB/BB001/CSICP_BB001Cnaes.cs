using System.ComponentModel.DataAnnotations;


namespace CSCore.Domain;

public partial class CSICP_BB001Cnaes
{
    public int TenantId { get; set; }

    [Key]
    public string Bb001PkId { get; set; } = null!;

    public string? Bb001Id { get; set; }

    public string? Bb001CnaeId { get; set; }

    public bool? Bb001Isactive { get; set; }

    public bool? Bb001IscnaeFiscal { get; set; }

    public CSICP_AA029 NavCnae { get; set; } = null!;

}
