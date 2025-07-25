namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD125
{
    public int TenantId { get; set; }

    public string Dd125CartacredId { get; set; } = null!;

    public string? Dd125FilialId { get; set; }

    public string? Dd120TrocaId { get; set; }

    public string? Dd125ContaId { get; set; }

    public DateTime? Dd125DataMovto { get; set; }

    public decimal? Dd125Vcarta { get; set; }

    public decimal? Dd125VsaldoCarta { get; set; }

    public string? Dd125UsuariopropId { get; set; }

    public int? Dd125StatusId { get; set; }

    public string? Dd125Email { get; set; }

    public string? Dd125Sms { get; set; }

    public string? Dd125Protocolnumber { get; set; }

    public bool? Dd125Islock { get; set; }

    public int? Dd125Tiporegid { get; set; }

}
