namespace CSCore.Domain;

public partial class CSICP_Bb020
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Empresaid { get; set; }

    public string? Bb019Id { get; set; }

    public string? Bb008Condicaodepagamentoid { get; set; }

    public decimal? Bb020Tcobcartao { get; set; }

    public string? Bb020Fpagtoid { get; set; }

    public CSICP_Bb008? Bb008Condicaodepagamento { get; set; }

    public CSICP_Bb019? Bb019 { get; set; }

    public CSICP_Bb026? Bb020Fpagto { get; set; }


}
