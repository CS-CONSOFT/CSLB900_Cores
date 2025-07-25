using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_BB.BB01X;

public partial class CSICP_BB015
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public string? Bb015Acessomarketplace { get; set; }

    public string? Bb015Cnpj { get; set; }

    public string? Bb015Marketplace { get; set; }

    public string? Bb015Skid { get; set; }
}
