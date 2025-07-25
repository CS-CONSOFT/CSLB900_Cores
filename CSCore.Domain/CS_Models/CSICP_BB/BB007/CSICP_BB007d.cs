using CSCore.Domain.CS_Models.CSICP_GG;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_BB007d
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb007dId { get; set; }

    public string? Bb007Responid { get; set; }

    public string? Gg001Almoxid { get; set; }
    public CSICP_GG001? CSICP_GG001 { get; set; }
}
