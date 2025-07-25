
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Bb065
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb065Id { get; set; }

    public long? Bb064Fxetariaid { get; set; }

    public long? Bb062Convenioid { get; set; }

    public CSICP_Bb060? Bb062Convenio { get; set; }

    //public CSICP_Bb064? Bb064Fxetaria { get; set; }
    //public CSICP_Bb066? CSICP_Bb066 { get; set; }
}
