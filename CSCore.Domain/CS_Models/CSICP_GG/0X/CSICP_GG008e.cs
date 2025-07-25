using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG008e
{
    public int TenantId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Gg008eId { get; set; }

    public string? Gg008eSeq { get; set; }

    public string? Gg008eDescricao { get; set; }

    public string? Gg008eCodigo { get; set; }

    public string? Gg008eProdutoid { get; set; }

    //public CSICP_GG008? Gg008eProduto { get; set; }
}
