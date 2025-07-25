using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Bb024
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb024Id { get; set; }

    public string? Bb025NatoperacaoId { get; set; }

    public int? Bb024CfopId { get; set; }

    public Osusr66cSpedInCfop? osusr66CSpedInCfop { get; set; }
}
