using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Bb067
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb067Id { get; set; }

    public string? Bb067Descricao { get; set; }

    public string? Bb067Codigo { get; set; }

    //public ICollection<CSICP_Bb060> OsusrE9aCsicpBb060s { get; set; } = new List<CSICP_Bb060>();
}
