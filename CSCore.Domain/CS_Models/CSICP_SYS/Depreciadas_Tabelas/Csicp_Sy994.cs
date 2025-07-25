namespace CSCore.Domain;

public partial class Csicp_Sy994
{
    public int TenantId { get; set; }

    public string Sy994Id { get; set; } = null!;

    public string? Sy994ExternalId { get; set; }

    public string? Sy994UsuarioId { get; set; }

    public int? Sy994PadraoId { get; set; }

    public bool? Sy994Padraofixo { get; set; }

    public DateTime? Sy994Datainclusao { get; set; }

    public string? Sy994UsuarioincId { get; set; }

    public string? Sy994EstabId { get; set; }

    public Csicp_Sy994Padrao? Sy994Padrao { get; set; }
}
