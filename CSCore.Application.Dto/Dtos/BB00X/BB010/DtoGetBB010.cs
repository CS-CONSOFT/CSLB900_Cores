namespace CSCore.Application.Dto.Dtos.BB00X.BB010
{
    public class DtoGetBB010
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = "";
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
    }
}