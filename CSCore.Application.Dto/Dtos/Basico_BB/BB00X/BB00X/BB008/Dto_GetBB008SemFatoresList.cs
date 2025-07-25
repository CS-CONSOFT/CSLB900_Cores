using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Domain;

namespace CSBS101.C82Application.Dto.BB00X.BB00X.BB008
{
    /// <summary>
    /// USADO NA LISTA DE FATORES DE ACRESCIMENTO QUE TA DENTRO DO BB008. AO REFERENCIAR UM BB008 QUE TAVA DENTRO DA LISTA
    /// DA BB017 QUE TAVA DENTRO DA BB008, O BB008 DE DENTRO DA LISTA DA BB017 NAO ESTAVA SENDO MAPEADO CORRETAMENTE NO SWAGGER
    /// </summary>
    public class Dto_GetBB008SemFatoresList
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Empresaid { get; set; }

        public int? Bb008Filial { get; set; }

        public int? Bb008Codigo { get; set; }

        public string? Bb008CondicaoPagto { get; set; }

        public int? Bb008Tipo { get; set; }

        public string? Bb008Condicao { get; set; }

        public int? Bb008Codformapagto { get; set; }

        public decimal? Bb008Vlrmaxformapagto { get; set; }

        public decimal? Bb008Vlrminformapagto { get; set; }

        public int? Bb008Entliquidada { get; set; }

        public int? Bb008Parcliquidadas { get; set; }

        public int? Bb008AprovaVenda { get; set; }

        public decimal? Bb008PercAcrescimo { get; set; }

        public decimal? Bb008PercDesconto { get; set; }

        public int? Bb008Indprecovenda { get; set; }

        public decimal? Bb008Percentrada { get; set; }

        public decimal? Bb008Valoracrescimo { get; set; }

        public decimal? Bb008Fatorjuros { get; set; }

        public bool? Bb008Isactive { get; set; }

        public int? Bb008Tipoid { get; set; }

        public int? Bb008Qtdparcela { get; set; }

        public CSICP_Bb008Tipo? NavBb008Tipo { get; set; }
        public CSICP_Statica? NavBB008_Aprova_Venda { get; set; }
        public CSICP_Statica? NavBB008_ParcLiquidadas { get; set; }
        public CSICP_Statica? NavBB008_EntLiquidada { get; set; }
        public Dto_GetBB001Simples? NavBB001Excibicao { get; set; }

    }

    public class Dto_GetBB008SemFatoresList_Simples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Empresaid { get; set; }

        public int? Bb008Filial { get; set; }

        public int? Bb008Codigo { get; set; }

        public string? Bb008CondicaoPagto { get; set; }

        public int? Bb008Tipo { get; set; }

        public string? Bb008Condicao { get; set; }

        public int? Bb008Codformapagto { get; set; }

        public decimal? Bb008Vlrmaxformapagto { get; set; }

        public decimal? Bb008Vlrminformapagto { get; set; }

        public int? Bb008Entliquidada { get; set; }

        public int? Bb008Parcliquidadas { get; set; }

        public int? Bb008AprovaVenda { get; set; }

        public decimal? Bb008PercAcrescimo { get; set; }

        public decimal? Bb008PercDesconto { get; set; }

        public int? Bb008Indprecovenda { get; set; }

        public decimal? Bb008Percentrada { get; set; }

        public decimal? Bb008Valoracrescimo { get; set; }

        public decimal? Bb008Fatorjuros { get; set; }

        public bool? Bb008Isactive { get; set; }

        public int? Bb008Tipoid { get; set; }

        public int? Bb008Qtdparcela { get; set; }
    }

    public class Dto_GetBB008_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb008Codigo { get; set; }

        //public string? Bb008CondicaoPagto { get; set; }

        //public int? Bb008Tipo { get; set; }

        public string? Bb008Condicao { get; set; }

        //public int? Bb008Codformapagto { get; set; }
    }


}
