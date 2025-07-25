
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CSCore.Domain;

public partial class CSICP_Bb062
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb062Id { get; set; }

    public int? Bb062Ano { get; set; }

    public int? Bb062Mes { get; set; }

    public string? Bb062Descritivo { get; set; }

    public DateTime? Bb062Dtemissao { get; set; }

    public string? Bb062Diavenctoid { get; set; }

    public int? Bb062Statusid { get; set; }

    public string? Bb062Estabid { get; set; }

    public CSICP_Bb037? NavBB037Diavencto { get; set; }

    public CSICP_Bb062Stum? NavBb062Status { get; set; }
}
