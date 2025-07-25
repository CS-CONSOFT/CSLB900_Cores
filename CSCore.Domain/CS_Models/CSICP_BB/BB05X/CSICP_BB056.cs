using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_Bb056
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb056Id { get; set; }

    public string? Bb056Profid { get; set; }

    public string? Bb056Contaid { get; set; }

    public string? Bb056Mensagem { get; set; }

    public decimal? Bb056Rate { get; set; }

    public DateTime? Bb056Datahora { get; set; }

    public bool? Bb056Isactive { get; set; }

    public bool? Bb056Issmsenviadoprof { get; set; }

    public bool? Bb056Issmsenviadocliente { get; set; }

    public DateTime? Bb056Dtsmsprof { get; set; }

    public DateTime? Bb056Dtsmscliente { get; set; }

    public CSICP_BB012? NavBB012 { get; set; }
}
