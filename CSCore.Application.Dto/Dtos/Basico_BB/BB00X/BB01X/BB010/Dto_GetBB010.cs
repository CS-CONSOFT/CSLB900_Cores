using CSBS101._82Application.Dto.BB00X.BB005;
using CSBS101._82Application.Dto.BB00X.BB006;
using CSBS101._82Application.Dto.BB00X.BB007;

namespace CSBS101._82Application.Dto.BB00X.BB01X.BB010
{
    public class Dto_GetBB010
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

        public Dto_GetBB006? NavBb010Banco01 { get; set; }

        public Dto_GetBB006? NavBb010Banco02 { get; set; }

        public Dto_GetBB006? NavBb010Banco03 { get; set; }

        public Dto_GetBB005? NavBb010Ccusto { get; set; }

        public Dto_GetBB007? NavBb010Vendedor { get; set; }
    }

    public class Dto_GetBB010_ZonaSimples
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


    }

    public class Dto_GetBB010_Zona_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb010Codigo { get; set; }

        public string? Bb010Zona { get; set; }




    }
}
