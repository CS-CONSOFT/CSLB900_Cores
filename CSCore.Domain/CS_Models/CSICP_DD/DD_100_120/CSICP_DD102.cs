namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD102
{
    public int TenantId { get; set; }

    public string Dd102ExecEntregaId { get; set; } = null!;

    public string? Dd102Contaid { get; set; }

    public string? Dd102EntregaId { get; set; }

    public decimal? Dd102QtdEntregar { get; set; }

    public string? Dd102CargaId { get; set; }

    public bool? Dd102Separado { get; set; }

    public bool? Dd102Checado { get; set; }

    public DateTime? Dd102DataEntrega { get; set; }

    public string? Dd102Obs { get; set; }

    public int? Dd102Volume { get; set; }

    public bool? Dd102Isactive { get; set; }

    public int? Dd102FluxoentId { get; set; }

    public decimal? Dd102Valorvenda { get; set; }

    public decimal? Dd102PesoBruto { get; set; }

    public decimal? Dd102PesoLiquido { get; set; }

    public string? Dd102Latitude { get; set; }

    public string? Dd102Longitude { get; set; }

    public string? Dd102Protocolnumber { get; set; }

    public bool? Dd102Issync { get; set; }

    public DateTime? Dd102DthrUltsync { get; set; }

    public CSICP_DD110? NavDD110Carga { get; set; }

    //public CSICP_DD101? NavDD101ListaEntrega { get; set; }

    public CSICP_DD101Flent? NavDD102FluxoEntrega { get; set; }


}
