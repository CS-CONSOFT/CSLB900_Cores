namespace CSSY103.C82Application.Dto.ABAC.Engine;

/// <summary>
/// Request para avaliação de permissão ABAC
/// </summary>
public record AbacPermissionRequest
{
    public string UserId { get; init; } = null!;
    public string ResourceId { get; init; } = null!;
    public string ActionName { get; init; } = null!;
    public int TenantId { get; init; }
    public Dictionary<string, object>? Context { get; init; }
}