using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Bb064
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb064Fxetariaid { get; set; }

    public string? Bb064Descricao { get; set; }

    public bool? Bb064Isactive { get; set; }

    //public ICollection<CSICP_Bb065> OsusrE9aCsicpBb065s { get; set; } = new List<CSICP_Bb065>();

    //public ICollection<CSICP_Bb066> OsusrE9aCsicpBb066s { get; set; } = new List<CSICP_Bb066>();
}
