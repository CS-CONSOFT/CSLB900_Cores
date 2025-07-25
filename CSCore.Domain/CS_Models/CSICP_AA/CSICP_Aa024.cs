using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_AA;

public partial class CSICP_Aa024
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public string? Aa024NomeUdh { get; set; }

    public string? Aa028Id { get; set; }

    public decimal? Aa024IdhmR { get; set; }

    public string? Aa024Ano { get; set; }

    public string? Aa027Id { get; set; }
    public CSICP_Aa028? NavAA028 { get; set; }
}
