using System.Runtime.CompilerServices;

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

    public bool IsRequestUserIdValid() => !string.IsNullOrWhiteSpace(UserId);
    public bool IsRequestResourceIdValid() => !string.IsNullOrWhiteSpace(ResourceId);
    public bool IsRequestActionNameValid() => !string.IsNullOrWhiteSpace(ActionName);

    public (bool, string) IsValidRequest()
    {
        if (!IsRequestUserIdValid())
            return (false, "UserId is null or empty.");
        if (!IsRequestResourceIdValid())
            return (false, "ResourceId is null or empty.");
        if (!IsRequestActionNameValid())
            return (false, "ActionName is null or empty.");
        return (true, string.Empty);
    }
}