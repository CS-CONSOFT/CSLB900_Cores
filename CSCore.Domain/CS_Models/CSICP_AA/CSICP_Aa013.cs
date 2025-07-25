
namespace CSCore.Domain;

public partial class CSICP_Aa013
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public decimal? Aa013Filial { get; set; }

    public string? Aa013Serie { get; set; }

    public decimal? Aa013Numero { get; set; }

    public DateTime? Aa013DataValidade { get; set; }

    public string? Aa013Filialid { get; set; }

    public int? Aa013ModId { get; set; }

    public bool? Aa013Isusocontigencia { get; set; }

    public OsusrNnxSpedInDocIcm? Aa013Mod { get; set; }

    public CSICP_BB001? Filial { get; set; }
    //public ICollection<CSICP_Aa014> OsusrE9aCsicpAa014s { get; set; } = new List<CSICP_Aa014>();
}
