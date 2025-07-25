using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Bb057
{
    public int TenantId { get; set; }


    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb057Id { get; set; }

    public string? Bb055Id { get; set; }

    public string? Bb012Id { get; set; }

    public DateTime? Bb057Datahora { get; set; }

    public bool? Bb057Issmsenvprof { get; set; }

    public bool? Bb057Issmsenvcliente { get; set; }

    public DateTime? Bb057Dtsmsprof { get; set; }

    public DateTime? Bb057Dtsmscliente { get; set; }
    public CSICP_BB012? NavBB012 { get; set; }
}
