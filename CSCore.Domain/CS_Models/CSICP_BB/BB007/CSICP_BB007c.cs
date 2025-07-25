
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

public partial class CSICP_BB007c
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb007cId { get; set; }

    public string? Bb007Responid { get; set; }

    //bb012_ContaID
    public string? Bb012Contaid { get; set; }

    public decimal? Bb007cPcomissao { get; set; }
    public CSICP_BB012? Bb012Conta { get; set; }
}
