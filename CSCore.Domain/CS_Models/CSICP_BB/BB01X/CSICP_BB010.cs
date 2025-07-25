
namespace CSCore.Domain;

public partial class CSICP_Bb010
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb010Codigo { get; set; }

    public string? Bb010Zona { get; set; }

    public int? Bb010CodVendedor { get; set; }

    public int? Bb010ColPrecoTabela { get; set; }

    public string? Bb010Banco01Id { get; set; }

    public string? Bb010Banco02Id { get; set; }

    public string? Bb010Banco03Id { get; set; }

    public string? Bb010CcustoId { get; set; }

    public int? Bb010Km { get; set; }

    public string? Bb010FoneContato { get; set; }

    public int? Bb010Promotor { get; set; }

    public string? Bb010Observacao { get; set; }

    public int? Bb010PeriodoRota { get; set; }

    public int? Bb010PeriodoVisita { get; set; }

    public string? Bb010TabelaPreco { get; set; }

    public string? Bb010Vendedorid { get; set; }

    public bool? Bb010Isactive { get; set; }

    public int? Bb010Tiporotaid { get; set; }

    public string? Bb010Cidadeid { get; set; }

    public CSICP_Bb006? Bb010Banco01 { get; set; }

    public CSICP_Bb006? Bb010Banco02 { get; set; }

    public CSICP_Bb006? Bb010Banco03 { get; set; }

    public CSICP_Bb005? Bb010Ccusto { get; set; }

    public CSICP_BB007? Bb010Vendedor { get; set; }
}
