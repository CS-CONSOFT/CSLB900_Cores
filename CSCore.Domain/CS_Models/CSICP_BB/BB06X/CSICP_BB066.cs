using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain;

/// <summary>
///  Detalhe Faixa Etaria
/// </summary>
public partial class CSICP_Bb066
{
    public int TenantId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Bb066Id { get; set; }

    public long? Bb066Fxetariaid { get; set; }

    public int? Bb066Faixade { get; set; }

    public int? Bb066Faixaate { get; set; }

    public decimal? Bb066Valor { get; set; }

    public CSICP_Bb064? Bb066Fxetaria { get; set; }
}
