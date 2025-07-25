namespace CSCore.Domain;

public partial class CSICP_BB01207
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Bb012TipoRegMembroconveni { get; set; }

    public string? Bb012Id { get; set; }

    public string? Bb012Membroid { get; set; }

    public bool? Bb01207IsActive { get; set; }

    public CSICP_BB012? NavBb012Membro { get; set; }
}
