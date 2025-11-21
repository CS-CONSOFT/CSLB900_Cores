using CSCore.Domain.CS_Models.Staticas.GG;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG520
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg520Filialid { get; set; }

    public string? Gg520KardexId { get; set; }

    public string? Gg520Almoxid { get; set; }

    public decimal? Gg520NsNumerosaldo { get; set; }

    public string? Gg520Descricaosaldo { get; set; }

    public int? Gg520Filial { get; set; }

    public int? Gg520Codalmoxarifado { get; set; }

    public int? Gg520Produto { get; set; }

    public decimal Gg520Saldo { get; set; } = -1;

    public decimal? Gg520Qtdcomprometida { get; set; }

    public decimal? Gg520QtdProducao { get; set; }

    public decimal? Gg520QtdEmpenho { get; set; }

    public decimal? Gg520QtdReserva { get; set; }

    public decimal? Gg520Qnpt { get; set; }

    public decimal? Gg520Qtnp { get; set; }

    public DateTime? Gg520Ultinventario { get; set; }

    public DateTime? Gg520Ultfechamento { get; set; }

    public decimal? Gg520Qtdultfechamento { get; set; }

    public bool? Gg520ItemEmContagem { get; set; }

    public DateTime? Gg520Proxinventario { get; set; }

    public DateTime? Gg520Ultrecebimento { get; set; }

    public decimal? Gg520Qtdultrecebto { get; set; }

    public DateTime? Gg520UltimaVenda { get; set; }

    public decimal? Gg520QtdeUltVenda { get; set; }

    public decimal? Gg520Qtdpedidocompra { get; set; }

    public string? Gg520Lote { get; set; }

    public string? Gg520Sublote { get; set; }

    public string? Gg520DescricaoLote { get; set; }

    public string? Gg520Compraid { get; set; }

    public int? Gg520CodgFornecedor { get; set; }

    public string? Gg520Contaid { get; set; }

    public string? Gg520Usuarioid { get; set; }

    public DateTime? Gg520DataFabricacao { get; set; }

    public DateTime? Gg520DataValidade { get; set; }

    public int? Gg520DiasValidade { get; set; }

    public int? Gg520Docto { get; set; }

    public string? Gg520Serie { get; set; }

    public DateTime? Gg520Compraentrada { get; set; }

    public string? Gg520Gradelinhaid { get; set; }

    public string? Gg520Gradecolunaid { get; set; }

    public string? Gg520Codggradelinha { get; set; }

    public string? Gg520Codggradecoluna { get; set; }

    public decimal? Gg520EstqMinimo { get; set; }

    public decimal? Gg520Estoquemaximo { get; set; }

    public string? Gg520Localizacaowms { get; set; }

    public decimal? Gg520Superpromocao { get; set; }

    public int? Gg520Periodicidadeinv { get; set; }

    public bool? Gg520Exibiremconsulta { get; set; }

    public bool? Gg520Saldozerodesabautom { get; set; }

    public bool? Gg520Permitetroca { get; set; }

    public decimal? Gg520Vbcstret { get; set; }

    public decimal? Gg520Vicmsstret { get; set; }

    public bool? Gg520Isactive { get; set; }

    [ForeignKey("Gg520Codbarras")]
    public string? Gg520CodbarrasId { get; set; }

    public DateTime? Gg520Timestamp { get; set; }

    public bool? Gg520Ispdv { get; set; }

    public decimal? Gg520Vicmssubstituto { get; set; }

    public string? Gg520VfuturaSaldoid { get; set; }

    public CSICP_GG001? NavGG001Almox { get; set; }

    public CSICP_GG019? Gg520Codbarras { get; set; }

    public CSICP_GG016? NavGG016Gradecoluna { get; set; }

    public CSICP_GG016? NavGG016Gradlinha { get; set; }

    public CSICP_GG008Kdx? Nav_GG008Kardex { get; set; }

}
