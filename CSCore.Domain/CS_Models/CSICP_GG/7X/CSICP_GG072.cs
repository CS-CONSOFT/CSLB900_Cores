using CSCore.Domain.CS_Models.Staticas.GG;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG072
{
    public int TenantId { get; set; }

    public long Gg072Id { get; set; }

    [ForeignKey("Gg071")]
    public long? Gg071Id { get; set; }

    public string? Gg072Codbarrasalfa { get; set; }

    public string? Gg072KardexId { get; set; }

    [ForeignKey("NavGG520Saidasaldo")]
    public string? Gg072Saidasaldoid { get; set; }

    public string? Gg072UnId { get; set; }

    public decimal? Gg072Quantidade { get; set; }

    public decimal? Gg072ValorUnitario { get; set; }

    public string? Gg072QtdAnterior { get; set; }

    [ForeignKey("Gg072Entradasaldo")]
    public string? Gg072Entradasaldoid { get; set; }

    public string? Gg072UnSecId { get; set; }

    public int? Gg072UnSecTipoconvId { get; set; }

    public decimal? Gg072UnSecFatorconv { get; set; }

    public decimal? Gg072UnSecQtde { get; set; }

    [ForeignKey("NavCSICP_GG072Stq")]
    public int? Gg072Statusestqid { get; set; }

    public string? Dd080Id { get; set; }

    public decimal? Gg072Qtdsolicitada { get; set; }

    [NotMapped]
    public string? GG008ProdutoDescricao { get; set; }

    public CSICP_GG071? Gg071 { get; set; }

    public CSICP_GG520? Gg072Entradasaldo { get; set; }

    public CSICP_GG520? NavGG520Saidasaldo { get; set; }
    public CSICP_GG072Stq? NavCSICP_GG072Stq    { get; set; }
}
