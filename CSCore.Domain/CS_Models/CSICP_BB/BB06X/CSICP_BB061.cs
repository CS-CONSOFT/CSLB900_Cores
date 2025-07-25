using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Bb061
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb061Id { get; set; }

    public long? Bb060Convenioid { get; set; }

    public int? Bb061Tipoassid { get; set; }

    public string? Bb012Contaid { get; set; }

    public string? Bb061Dependenteid { get; set; }

    public decimal? Bb061Valor { get; set; }

    public bool? Bb061Isactive { get; set; }

    public CSICP_Bb060? NavBb060Convenio { get; set; }

    public CSICP_Bb061Tp? Bb061Tipoass { get; set; }

    public CSICP_BB012? CSICP_BB012 { get; set; }
    public CSICP_BB01208? CSICP_BB01208 { get; set; }
}
