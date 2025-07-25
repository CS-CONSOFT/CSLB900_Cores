namespace CSCore.Domain;

public partial class CSICP_Bb005
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb005Filial { get; set; }

    public int? Bb005Codigo { get; set; }

    public string? Bb005Nomeccusto { get; set; }

    public int? Bb005Colunaimpressao { get; set; }

    public string? Empresaid { get; set; }

    public bool? Bb005Isactive { get; set; }

    //public ICollection<CSICP_BB007> OsusrE9aCsicpBb007s { get; set; } = new List<CSICP_BB007>();

    //public ICollection<CSICP_Bb010> OsusrE9aCsicpBb010s { get; set; } = new List<CSICP_Bb010>();

    //public ICollection<CSICP_Bb060> OsusrE9aCsicpBb060s { get; set; } = new List<CSICP_Bb060>();
}
