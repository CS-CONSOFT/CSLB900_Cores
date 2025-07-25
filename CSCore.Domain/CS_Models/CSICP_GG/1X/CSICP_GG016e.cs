using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG016e
{
    public int TenantId { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Gg016eId { get; set; }

    public string? Gg016eDescricao { get; set; }

    public DateTime? Gg016eDregistro { get; set; }

    public string? Gg016eUsuariopropid { get; set; }

    public Csicp_Sy001? NavProprietarioSY001 { get; set; }

    //public ICollection<OsusrE9aCsicpGg016f> OsusrE9aCsicpGg016fs { get; set; } = new List<OsusrE9aCsicpGg016f>();
}
