
namespace CSCore.Domain;

public partial class CSICP_BB012j
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Bb012Id { get; set; }

    public string? Bb012jTelefone { get; set; }

    public string? Bb012jFax { get; set; }

    public string? Bb012jEmail { get; set; }

    public int? Bb012jTipoendereco { get; set; }

    public CSICP_Bb012jTpend? NavTipoEndereco { get; set; }
    public CSICP_BB01206? NavBB1206_Endereco { get; set; }
}
