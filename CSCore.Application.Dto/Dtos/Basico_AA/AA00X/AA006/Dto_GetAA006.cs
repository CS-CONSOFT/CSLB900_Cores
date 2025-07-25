using CSBS101._82Application.Dto.BB00X.BB001;

namespace CSBS101._82Application.Dto.AA00X.AA006;

public class Dto_GetAA006
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Aa006Filial { get; set; }

    public string? Aa006Arquivo { get; set; }

    public decimal? Aa006Ci { get; set; }

    public string? Aa006Filialid { get; set; }

    public DateTime? Aa006Dataultcaptura { get; set; }

    public int? Aa006Circular { get; set; }

    public decimal? Aa006Maxcircular { get; set; }

    // public CSICP_Statica? NavAa006CircularNavigation { get; set; }

    public Dto_GetBB001? NavFilialBB001 { get; set; }
}
