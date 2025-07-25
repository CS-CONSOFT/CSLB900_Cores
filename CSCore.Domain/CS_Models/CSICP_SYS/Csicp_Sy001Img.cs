using System.Text.Json.Serialization;

namespace CSCore.Domain;

public partial class Csicp_Sy001Img
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? UsuarioId { get; set; }

    public string? Nome { get; set; }

    public string? Tipo { get; set; }

    public bool? Isactive { get; set; }

    public bool? Ispadrao { get; set; }

    public string? Path { get; set; }


}
