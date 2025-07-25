namespace CSCore.Domain;

public partial class CSICP_AA029
{
    public int TenantId { get; set; }

    public string Aa029Id { get; set; } = null!;

    public string? Aa029Cnae { get; set; }

    public string? Aa029Descricao { get; set; }

    public string? Aa029Notaexplicativa { get; set; }

    public bool? Aa029Isactive { get; set; }

    // public  ICollection<CSICP_BB001Cnaes> OsusrE9aCsicpBb001Cnaes { get; set; } = new List<CSICP_BB001Cnaes>();
}
