namespace CSCore.Domain;

public partial class Csicp_Sy001Bio
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? UsuarioId { get; set; }

    public string? Nome { get; set; }

    public string? Tipo { get; set; }

    public byte[]? Biometria { get; set; }

    public bool? Isactive { get; set; }

    public string? BiometriaTexto { get; set; }

    public Csicp_Sy001? Usuario { get; set; }
}
