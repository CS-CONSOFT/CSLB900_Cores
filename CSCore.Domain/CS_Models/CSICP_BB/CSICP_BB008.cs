namespace CSCore.Domain;

public partial class CSICP_Bb008
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

    public CSICP_Bb008Tipo? CSICP_Bb008Tipo { get; set; }
    public CSICP_Statica? NavBB008_Aprova_Venda { get; set; }
    public CSICP_Statica? NavBB008_ParcLiquidadas { get; set; }
    public CSICP_Statica? NavBB008_EntLiquidada { get; set; }

    public CSICP_BB001? CSICP_BB001 { get; set; }


    //public ICollection<CSICP_Bb017> OsusrE9aCsicpBb017s { get; set; } = new List<CSICP_Bb017>();

    //public ICollection<CSICP_Bb020> OsusrE9aCsicpBb020s { get; set; } = new List<CSICP_Bb020>();

    //public ICollection<CSICP_Bb026> OsusrE9aCsicpBb026s { get; set; } = new List<CSICP_Bb026>();

    //public ICollection<CSICP_Bb060> OsusrE9aCsicpBb060s { get; set; } = new List<CSICP_Bb060>();
}
