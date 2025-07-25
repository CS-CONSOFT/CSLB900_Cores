using System.ComponentModel.DataAnnotations;

namespace CSCore.Domain.CS_Models.CSICP_BB.BB06X;

public partial class CSICP_BB063
{
    public int TenantId { get; set; }

    [Key]
    public long Bb063Id { get; set; }

    public long? Bb063Convenioid { get; set; }

    public int? Bb061Tipoassid { get; set; }

    public string? Bb012Contaid { get; set; }

    public decimal? Bb063Valor { get; set; }

    public string? Bb063Custoid { get; set; }

    public string? Bb063Usuarioproprieid { get; set; }

    public string? Bb063Agcobradorid { get; set; }

    public string? Bb063Responsavelid { get; set; }

    public string? Bb063Condicaoid { get; set; }

    public string? Bb063Tipocobrancaid { get; set; }

    public string? Ff102Id { get; set; }

    public long? Bb062RefId { get; set; }

    public string? Bb063FpagtoId { get; set; }

    public string? Bb063Dependenteid { get; set; }

    public long? Bb063Convmasterid { get; set; }
}
