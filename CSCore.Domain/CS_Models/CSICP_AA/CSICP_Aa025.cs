namespace CSCore.Domain;

public partial class CSICP_Aa025
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Aa025Codigopais { get; set; }

    public string? Aa025Descricao { get; set; }

    public int? Aa025Codigobacen { get; set; }

    public int? Aa025Codigosiscomex { get; set; }

    public bool? Aa025Isactive { get; set; }

    public string? Aa025Nacionalidade { get; set; }

    public string? Aa025Iso3166A2 { get; set; }

    public string? Aa025Iso3166A3 { get; set; }

    public int? Aa025Iso3166N3 { get; set; }

    public string? Aa025ExportPaisid { get; set; }

    public int? Aa025CodigoNacoesunidas { get; set; }

    //public ICollection<CSICP_Aa027> OsusrE9aCsicpAa027s { get; set; } = new List<CSICP_Aa027>();

    //public ICollection<CSICP_BB001Global> OsusrE9aCsicpBb001Globals { get; set; } = new List<CSICP_BB001Global>();

    //public ICollection<CSICP_BB001> OsusrE9aCsicpBb001s { get; set; } = new List<CSICP_BB001>();
}
