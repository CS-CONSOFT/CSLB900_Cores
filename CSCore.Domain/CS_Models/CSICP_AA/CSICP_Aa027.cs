namespace CSCore.Domain;

public partial class CSICP_Aa027
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Aa027Sigla { get; set; }

    public string? Descricao { get; set; }

    public decimal? Aa027Percicmscontrib { get; set; }

    public decimal? Aa027Percicmsncontrib { get; set; }

    public decimal? Aa027Percsubsttribut { get; set; }

    public string? Aa027Mascinsestadual { get; set; }

    public decimal? Aa027Percicmsentrada { get; set; }

    public string? Aa027Mascieimpressao { get; set; }

    public int? Aa027Codigoibge { get; set; }

    public string? Paisid { get; set; }

    public string? Regiaoid { get; set; }

    public string? Aa027Naturalidade { get; set; }

    public string? Aa027ExportUfid { get; set; }

    public string? Aa025ExportPaisid { get; set; }

    public string? Aa026ExportRegiaoid { get; set; }

    //public  ICollection<CSICP_Aa028> OsusrE9aCsicpAa028s { get; set; } = new List<CSICP_Aa028>();

    //public  ICollection<CSICP_Aa040> OsusrE9aCsicpAa040Aa040Ufdestinos { get; set; } = new List<CSICP_Aa040>();

    //public  ICollection<CSICP_Aa040> OsusrE9aCsicpAa040Aa040Uforigems { get; set; } = new List<CSICP_Aa040>();

    //public  ICollection<CSICP_Aa042> OsusrE9aCsicpAa042s { get; set; } = new List<CSICP_Aa042>();

    //public  ICollection<CSICP_BB001Global> OsusrE9aCsicpBb001Globals { get; set; } = new List<CSICP_BB001Global>();

    //public  ICollection<CSICP_BB001> OsusrE9aCsicpBb001s { get; set; } = new List<CSICP_BB001>();

    public CSICP_Aa025? Pais { get; set; }

    public CSICP_Aa026? Regiao { get; set; }
}
