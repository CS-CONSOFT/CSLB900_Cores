using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG016f
{
    public int TenantId { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Gg016fId { get; set; }

    public long? Gg016eId { get; set; }

    public string? Gg016fGradelinhaid { get; set; }

    public string? Gg016fGradecolunaid { get; set; }


    public CSICP_GG016? NavGg016fGradecoluna { get; set; }
    public CSICP_GG016? NavGg016fGradelinha { get; set; }

}
