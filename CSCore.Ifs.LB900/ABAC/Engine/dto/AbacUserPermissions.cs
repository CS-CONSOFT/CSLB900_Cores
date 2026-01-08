namespace CSSY103.C82Application.Dto.ABAC.Engine;

/// <summary>
/// Permissões de um usuário para um recurso
/// </summary>
public record AbacUserPermissions
{
    public string UserId { get; init; } = null!;
    public string ResourceId { get; init; } = null!;
    public string ResourceName { get; init; } = null!;
    public List<string> AllowedActions { get; init; } = new();
    public List<string> DeniedActions { get; init; } = new();
}