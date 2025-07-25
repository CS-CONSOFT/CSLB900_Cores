namespace CSCore.Domain;

public partial class OsusrNnxSpedInDocIcm
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public string? Codigo { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public bool? Cupom { get; set; }

    public bool? Docfiscal { get; set; }

    //public ICollection<CSICP_Aa013> OsusrE9aCsicpAa013s { get; set; } = new List<CSICP_Aa013>();
}
